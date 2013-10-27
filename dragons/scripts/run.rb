#!/usr/bin/env ruby

require_relative "../src/html-visualizer.rb"

usage = <<eos
./run.rb <input_file> <rooms|teachers|groups>
  parses a given JSON input file and visualizes the solution to the course
  scheduling problem by giving time tables in terms of rooms, teachers or
  groups as HTML output
eos

puts usage unless ARGV.size == 2
Visualizer::HTMLVisualizer.visualize(*ARGV)
