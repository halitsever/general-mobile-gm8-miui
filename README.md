<p align="center" class="logo-section">
<img src="web/assets/favicon.png" height="80" width="80" alt="GMIUI logo"/>
<br/>
<img src="https://halitsever-api.vercel.app/api/repo-title?title=GMIUI">

<p align="center">
GMIUI is a MIUI 11 custom ROM for the General Mobile GM8 Android smartphone, with a Windows fastboot installer for single and dual SIM models.<br>
<br/>
<br/>
<img src="https://img.shields.io/github/sponsors/halitsever" alt="GitHub Sponsors"/>
</p>
<p align="center">
<a align="center" href="https://halitsever.github.io/general-mobile-gm8-miui/">Documentation</a>
  </p>
</p>

<p align="center">
<img src="https://halitsever-api.vercel.app/api/details"/>
</p>

<img align="right" width="250" height="250"  alt="General Mobile GM8 MIUI" src="https://i.ibb.co/Btzv1Mf/7946231600-LO1-20180315-103535.png">

MIUI deployments for <b>General Mobile GM8 devices</b>, you can install <b>General Mobile GM8 MIUI</b> software effortlessly, which is designed for users who want to customize their device and have a different experience. Unstable versions may not work properly for <b>GM 8</b>.

- **MIUI EU 11.0.10** (stable) and **MIUI Global 11.0.7** (unstable) builds for single and dual SIM devices
- Installs to both A and B slots, GSI based, 1.6 GB in total
- MIUI Camera included, missing system apps installed and updated, brightness and flashlight fixed, VoLTE and fingerprint working
- **GM8 MIUI Installer**: a Windows Forms app (.NET Framework 4.7.2, MaterialSkin.2) that flashes the ROM over fastboot
- Optional mods on the [download page](https://halitsever.github.io/general-mobile-gm8-miui/): Mi boot splash, Magisk root, Dolby Audio and Google Camera

**Supported devices**

General Mobile GM8 <a href="https://halitsever.github.io/general-mobile-gm8-miui/">(checkout this release)</a><br>
General Mobile GM8 2020 Edition <a href="https://halitsever.github.io/general-mobile-gm8-miui/">(checkout this release)</a><br>
<s>General Mobile GM8 Go</s> <a href="#">(checkout this release)</a><br>

**Responsibility & Known bugs**

<img align="left" width="250" height="250" alt="General Mobile GM8 MIUI comparison" src="https://i.ibb.co/Y7MtPNt/compare-gm8.png">
Bluetooth headset call (calls only, no problem with music),<br>
Root should not be discarded, causing errors in boot split, <br>
Opening MIUI optimization is not recommended because it is specific to Xioami devices. <br>
It is made for users from users, it is not the official gm8 or xiaomi-miui page. You are responsible for your actions.
<br clear="all"/>

**Credits**

Splash flasher tool by murat100, Mi splash by Neqative/RomRunner. Thanks to cıyanogen, erdil, yey59, resul, barishirece, reloaded2023 and ismail zeyrek.

<p align="center" >
<img src="https://halitsever-api.vercel.app/api/installation"/>
</p>

1. Download the ROM for your model from the [download page](https://halitsever.github.io/general-mobile-gm8-miui/). The stable MIUI EU 11.0.10 build is recommended.
2. Boot the GM8 into fastboot mode and connect it over USB.
3. Open the GM8 MIUI Installer in the ROM folder, pick **Single** or **Dual** SIM and click **INSTALL MIUI**.

The installer runs these fastboot commands, where `<sim>` is `single` or `dual`:

```
fastboot erase userdata
fastboot flash userdata <sim>/userdata.img
fastboot flash system_a sistem/system.img
fastboot flash system_b sistem/system.img
fastboot flash boot_a <sim>/boot.img
fastboot flash boot_b <sim>/boot.img
fastboot flash vendor_a <sim>/vendor.img
fastboot flash vendor_b <sim>/vendor.img
fastboot flash splash <sim>/splash.img
```

If the phone gets stuck on the Mi logo, open `dev-config.exe` in the ROM folder and run `fastboot flash boot single/boot.img` (`dual/boot.img` on dual SIM models) to reset the boot partition. The TWRP restore steps for MIUI Global 11.0.7 and the mod guides are on the download page (in Turkish).

To build the installer, open `src/GM8 MIUI.sln` in Visual Studio, restore the NuGet packages and build. It needs .NET Framework 4.7.2 and `fastboot.exe` next to the app or on `PATH`.

<p align="center">
<a href="https://github.com/halitsever/general-mobile-gm8-miui/issues"><img src="https://halitsever-api.vercel.app/api/issue"/></a>
</p>

<p align="center">
Found a bug or have an idea? Open an <a href="https://github.com/halitsever/general-mobile-gm8-miui/issues">issue</a>.<br/>
Read the <a href=".github/CONTRIBUTING.md">contributing guide</a> before sending a pull request.
</p>

<p align="center">
<img src="https://halitsever-api.vercel.app/api/sponsor"/>
</p>

<p align="center">
<img src="https://halitsever-api.vercel.app/api/license"/>
</p>

<p align="center">
Released under the <a href="LICENSE">MIT License</a>.
</p>
