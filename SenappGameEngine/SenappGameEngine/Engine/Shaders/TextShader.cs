﻿using OpenTK;
using Senapp.Engine.Entities;
using Senapp.Engine.UI;

namespace Senapp.Engine.Shaders
{
    public class TextShader : ShaderProgram
    {
        private static readonly string VERTEX_SHADER_FILE = "Resources/Shaders/textVertexShader.glsl";
        private static readonly string FRAGMENT_SHADER_FILE = "Resources/Shaders/textFragmentShader.glsl";

        private int location_transformationMatrix;
        private int location_viewMatrix;
        private int location_projectionMatrix;
        private int location_colour;



        public TextShader() : base(VERTEX_SHADER_FILE, FRAGMENT_SHADER_FILE) { }

        protected override void BindAttributes()
        {
            base.BindAttribute(0, "position");
            base.BindAttribute(1, "textureCoords");
        }

        protected override void GetAllUniformLocations()
        {
            location_transformationMatrix = base.GetUniformLocation("transformationMatrix");
            location_viewMatrix = base.GetUniformLocation("viewMatrix");
            location_projectionMatrix = base.GetUniformLocation("projectionMatrix");
            location_colour = base.GetUniformLocation("colour");
        }
        public void LoadColour(Vector3 colour)
        {
            base.LoadVector(location_colour, colour);
        }
        public void LoadTransformationMatrix(Matrix4 matrix)
        {
            base.LoadMatrix(location_transformationMatrix, matrix);
        }
        public void LoadViewMatrix(Matrix4 matrix)
        {
            base.LoadMatrix(location_viewMatrix, matrix);
        }
        public void LoadProjectionMatrix(Matrix4 matrix)
        {
            base.LoadMatrix(location_projectionMatrix, matrix);
        }
        public void UpdateCamera(Camera camera)
        {
            LoadViewMatrix(camera.GetViewMatrixUI());
            LoadProjectionMatrix(camera.GetProjectionMatrixUI());
        }
    }
}
