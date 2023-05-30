from bokeh.plotting import figure, show, output_file
import json
import os

def show_iterations(iterations):
	p = figure(title="Iterations evolution over time", x_axis_label="Evaluations", y_axis_label="Iterations")
	
	iterations_num = []
	for i in range(len(iterations)):
		iterations_num.append(i+1)
	
	p.line(iterations_num, iterations, line_width=2)
	
	output_file("plot1.html")
	show(p)

def show_actions(actions):
	
	action_names = []
	action_counts = []
	for action in actions:
		action_names.append(action["n