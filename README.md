webp-unity3d
============

Based on [https://github.com/octo-code/webp-unity3d](https://github.com/octo-code/webp-unity3d)

Windows build of `libwebp` 0.5.2 were taken from here:

* https://s3.amazonaws.com/resizer-dynamic-downloads/webp/0.5.2/x86_64/libwebp.dll
* https://s3.amazonaws.com/resizer-dynamic-downloads/webp/0.5.2/x86/libwebp.dll

To include this into your project, you can use `npm` method of unity package manament described [here](https://github.com/minhhh/UBootstrap). After installing this package, there's one extra step: Adding `--unsafe` to `Assets/smcr.rsp`.
