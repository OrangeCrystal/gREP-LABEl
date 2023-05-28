from bokeh.plotting import figure, show, output_file
import json
import os

def show_iterations(iterations):
	p = figure(title="Iterations evolution over time", x_axis_label="Evaluations", y_axis_label="Iterations")
	
	iterations_num = []
	for i in range(len(iterations)):
		iterations_num