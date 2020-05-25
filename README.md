
![enter image description here](https://i.ibb.co/LC0CqsL/android-1869510-1280.jpg)\
**ADB GUI Rom Installer**
Minimal adb & fastboot toolun geliştirilerek GUI haline dönüştürülmüş halidir. Bu sayede rom yüklemek paylaşılan kullanıcıya daha kolay olması amaçlanmıştır.

**Kendi romunuzu uyarlamak**
Uygulamanın klasörünün içinde single ve dual adında iki klasör açın, bir de sistem adlı klasör açın.

Single ve dual klasör içeriğine şunları koyun:
vendor.img
boot.img
splash.img
userdata.img

Dual ve single için vendor,boot,splash özel olmak zorundadır, yoksa çift hatlı cihazlarda 2.hat çalışmaz, wifi bağlanmaz.

**Bat dosyalarındaki içeriği değiştirmek**
Bunun için ascii textleri klasörün içerisinde bulunan logo.txt, owner.txt dosyalarına gömmelisiniz.

**Bu GUI ile hazırlanmış romlar:**
[GM8 MIUI ROM](https://gm8miui.glitch.me/)

