require "json"

module Visualizer
  module Parser
    class << self
      def parse(input_file, grouping)
        scheduled_slots = JSON.parse(File.read(input_file))
        scheduled_slots = expand(scheduled_slots)
        Hash[
          grouping(scheduled_slots, grouping).map do |group, ss|
            [group, ss.group_by { |ss| ss["timeSlot"]["Day"] }]
          end
        ]
      end

      private

      def expand(scheduled_slots)
        scheduled_slots.map do |ss|
          ss["subject"]["teachers"].map do |teacher|
            deep_copy(ss).tap { |ss| ss["subject"]["teacher"] = teacher }
          end
        end
        .flatten
        .map do |ss|
          ss["groups"].map do |group|
            deep_copy(ss).tap { |ss| ss["group"] = group }
          end
        end
        .flatten
      end

      def grouping(scheduled_slots, grouping)
        scheduled_slots.group_by do |ss|
          case grouping
          when "rooms" then ss["room"]["nameOrNumber"]
          when "teachers" then ss["subject"]["teacher"]["name"]
          when "groups" then ss["group"]["name"]
          else raise ArgumentError, "Grouping must be either by rooms, teachers or groups"
          end
        end
      end

      def deep_copy(x)
        Marshal.load(Marshal.dump(x))
      end
    end
  end
end
