[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
[![Actions Status](https://github.com/smack0007/GLESDotNet/workflows/CI/badge.svg)](https://github.com/smack0007/GLESDotNet/actions)
[![NuGet Badge](https://buildstats.info/nuget/GLESDotNet)](https://www.nuget.org/packages/GLESDotNet/)

# GLESDotNet

[OpenGLES](https://www.khronos.org/opengles/) bindings for .NET. Uses [ANGLE](https://chromium.googlesource.com/angle/angle/+/master/README.md) 
for Desktop platforms. Currently only tested / works on Windows but should be fairly easy to make it work on other platforms. Pull requests are welcome.

## Samples

Check out the [sample projects](https://github.com/smack0007/GLESDotNet/tree/master/samples/) to see examples
on how to work with GLESDotNet. The samples used the common project
[GLESDotNet.Samples](https://github.com/smack0007/GLESDotNet/tree/master/samples/GLESDotNet.Samples) for
getting a window and rendering context set up.

The samples can be quite repetative and this is by design. When you're looking to learn how to get things
done you don't have to look in too many places.

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


