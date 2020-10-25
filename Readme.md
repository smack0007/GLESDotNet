[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
[![Actions Status](https://github.com/smack0007/GLESDotNet/workflows/CI/badge.svg)](https://github.com/smack0007/GLESDotNet/actions)
[![NuGet Badge](https://buildstats.info/nuget/GLESDotNet)](https://www.nuget.org/packages/GLESDotNet/)

# GLESDotNet

[OpenGLES](https://www.khronos.org/opengles/) bindings for .NET. Uses [ANGLE](https://chromium.googlesource.com/angle/angle/+/master/README.md) 
for Desktop platforms. Currently only tested / works on Windows but should be fairly easy to make it work on other platforms. Pull requests are welcome.

## Samples

Check out the [sample projects](https://github.com/smack0007/GLESDotNet/tree/master/samples/) to see examples
on how to work with GLESDotNet.

- [Hello Triangle](https://github.com/smack0007/GLESDotNet/tree/master/samples/HelloTriangle): The Hello World
sample for getting started with GLESDotNet.

- [Hello Textures](https://github.com/smack0007/GLESDotNet/tree/master/samples/HelloTextures): Adds to the
[Hello Triangle](https://github.com/smack0007/GLESDotNet/tree/master/samples/HelloTriangle) sample. Draws a
textured quad.

- [Framebuffer](https://github.com/smack0007/GLESDotNet/tree/master/samples/Framebuffer): Uses a framebuffer
to implement a post processing effect.

- [Flames](https://github.com/smack0007/GLESDotNet/tree/master/samples/Flames): Implements a flame effect
in front of the OpenGLES logo.

- [Sprites](https://github.com/smack0007/GLESDotNet/tree/master/samples/Spites): Renders 2D sprites. 

- [ImGui](https://github.com/smack0007/GLESDotNet/tree/master/samples/ImGui): Uses
[ImGui.NET](https://github.com/mellinoe/ImGui.NET) to render a GUI with [Dear ImGui](https://github.com/ocornut/imgui).

The samples use the common project [GLESDotNet.Samples](https://github.com/smack0007/GLESDotNet/tree/master/samples/GLESDotNet.Samples).
There are also a few classes in the project that could be interesting for use in your own projects:

- [GLApplication](https://github.com/smack0007/GLESDotNet/blob/master/samples/GLESDotNet.Samples/GLApplication.cs):
Base class used in all the samples. Gets the context set up and provides life cycle events for your application.
Depends on [GLFWDotNet](https://github.com/smack0007/GLFWDotNet).

- [GLUtils](https://github.com/smack0007/GLESDotNet/blob/master/samples/GLESDotNet.Samples/GLUtils.cs): Contains
some simple helper methods for working with OpenGLES.

- [SpriteRenderer](https://github.com/smack0007/GLESDotNet/blob/master/samples/GLESDotNet.Samples/SpriteRenderer.cs):
Renders 2D sprites.

- [TextureData](https://github.com/smack0007/GLESDotNet/blob/master/samples/GLESDotNet.Samples/TextureData.cs): 
Simple data class used for holding texture information. 

You are free to copy these classes into your own projects and change the namespace to your liking. 
