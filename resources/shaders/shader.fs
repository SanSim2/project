#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;

void main()
{
    vec4 texColor = texture(texture1, TexCoords);
    if(texColor.a < 0.1) // ako alpha vrednost boje je manja od 0.1 nemoj da je crtas i tako dobijavo transparentnost
        discard;
    FragColor = texColor;
}