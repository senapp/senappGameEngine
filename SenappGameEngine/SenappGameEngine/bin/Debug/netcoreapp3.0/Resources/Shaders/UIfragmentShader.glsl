﻿#version 400

in vec2 pass_textureCoords;

out vec4 out_Colour;

uniform sampler2D textureSampler;
uniform vec3 colour;


void main(){
		vec4 colourBase = texture(textureSampler, pass_textureCoords);
		if (colourBase.a < 0.5){
			discard;
		}
		out_Colour = colourBase * vec4(colour, 1);

}