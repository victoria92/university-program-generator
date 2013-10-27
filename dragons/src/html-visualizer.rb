# encoding: UTF-8

require "nokogiri"

require_relative "./parser"

module Visualizer
  module HTMLVisualizer
    class << self
      def visualize(input_file, grouping)
        scheduled_slots = Parser.parse(input_file, grouping)
        puts build_html(scheduled_slots)
      end

      private

      START_HOUR = 7
      END_HOUR = 22
      DAYS_OF_WEEK = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"]

      def fill_in_timetable(scheduled_slots)
        timetable = []
        (0..DAYS_OF_WEEK.size).each do |i|
          timetable[i] = []
        end

        scheduled_slots.values.flatten.each do |ss|
          # FIXME ugly, this is some index and we have no notion of what it means
          day_index = (ss["timeSlot"]["Day"] + 6) % 7

          start_hour = ss["timeSlot"]["StartHour"]
          end_hour = ss["timeSlot"]["EndHour"]
          timetable[day_index][start_hour] = ss
          ((start_hour + 1)...end_hour).each do |hour|
            timetable[day_index][hour] = :occupied
          end
        end

        timetable
      end

      def build_html(scheduled_slots_by_label)
        html = Nokogiri::HTML::Builder.new(encoding: "UTF-8") do |doc|
          doc.html {
            doc.head {
              doc.link({href: "style.css", rel: "stylesheet", type: "text/css"})
              doc.meta({:"http-equiv" => "Content-type", :content => "text/html;charset=UTF-8"})
            }
            doc.body {
              scheduled_slots_by_label.each do |label, scheduled_slots|
                visualize_table(doc, label, scheduled_slots)
              end
            }
          }
        end.to_html
      end

      def visualize_table(doc, label, scheduled_slots)
        table = fill_in_timetable(scheduled_slots)
        doc.p {
          doc.table {
            doc.tr {
              doc.th({colspan: DAYS_OF_WEEK.size + 1}, label)
            }
            doc.tr {
              doc.th
              ["Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота"].each do |day|
                doc.th day
              end
            }
            (START_HOUR...END_HOUR).each do |hour|
              doc.tr {
                doc.td "#{hour}:00"

                DAYS_OF_WEEK.each_with_index do |_, i|
                  case table[i][hour]
                  when nil then doc.td({class: "subject"}) { doc.cdata "&nbsp;" }
                  when :occupied
                  else
                    ss = table[i][hour]
                    timeslot = ss["timeSlot"]
                    duration = timeslot["EndHour"] - timeslot["StartHour"]
                    groups = ss["groups"]
                              .map{ |g| g["name"] }
                              .join("<br/>")
                    label = "#{ss["subject"]["name"]}<br/>#{groups}"
                    doc.td({rowspan: duration, class: "subject"}) {
                      doc.cdata label
                    }
                  end
                end
              }
            end
          }
        }
      end
    end
  end
end
