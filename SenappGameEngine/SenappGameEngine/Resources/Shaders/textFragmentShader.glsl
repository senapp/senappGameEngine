﻿
#version 400

in vec2 pass_textureCoords;

out vec4 out_Colour;

uniform sampler2D textureSampler;
uniform vec4 colour;
uniform float colourMixRatio;
uniform vec2 screenSize;



void main(){
		vec4 colourBase = texture(textureSampler, pass_textureCoords);
		if (colourBase.a < 0.5){
			discard;
		}
		out_Colour = mix(colourBase, colour, colourMixRatio);

}