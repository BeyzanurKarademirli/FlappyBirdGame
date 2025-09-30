# FlappyBirdGame
Proje Adı: Flappy Bird Game
Geliştirici: Beyzanur KARADEMİRLİ
Platform: Windows
Dil / Teknoloji: C# (.NET Framework), Windows Forms, Visual Studio 2022, DevExpress
Durum: Tamamlandı

1. Proje Hakkında

Bu proje, klasik Flappy Bird oyununu Windows Forms kullanarak yeniden yaratmayı hedefler.
Kullanıcı, boşluk tuşuna (Space) basarak kuşu zıplatır ve ekrandaki borular arasından geçmeye çalışır. Amaç mümkün olduğunca yüksek skor elde etmektir.

Oyun, temel olarak aşağıdaki özellikleri içerir:

Kuşun yukarı zıplaması ve yerçekimi ile düşüşü

Boruların sürekli soldan sağa hareket etmesi

Skor takip sistemi

Oyun bittiğinde “Yeniden Oyna” butonu ile oyunu baştan başlatabilme

Oyun başlangıcı ve restart sonrası düzgün kuş hareketi

2. Özellikler

Basit ve anlaşılır kontroller:

Space tuşu ile kuşu zıplatabilirsiniz.

Restart butonu ile oyun baştan başlar.

Oyun Mekaniği:

Borular sabit hızla soldan sağa hareket eder.

Skor her boru geçişinde artar.

Kuş boruya veya zemine çarptığında oyun biter.

Dinamik Zorluk:

Skor > 5 olduğunda boruların hızı artar.

Yeniden Başlat:

Kuş, borular ve skor sıfırlanır.

Form focus’u geri gelir, böylece Space tuşu hemen çalışır.

3. Kullanılan Teknolojiler

C# ve .NET Framework 4.x: Oyun mantığı ve event sistemi için

Windows Forms (WinForms): Kullanıcı arayüzü ve grafikler

Visual Studio 2022: IDE ve geliştirme ortamı

DevExpress: UI bileşenleri ve tasarım

Resimler: Flappy Bird, Boru, Zemin ve Oyun başlığı (screenshot)

4. Kurulum ve Çalıştırma

Proje dosyasını GitHub’dan veya zip olarak indirin.

Visual Studio 2022 ile projeyi açın.

Resources klasöründe kuş ve boru görsellerinin bulunduğundan emin olun:

flappyBird.png

BoruAlt.png

BoruUst.png

zemin.png

Projeyi derleyin ve çalıştırın (F5).

Oyunu Space tuşu ile oynayın.

5. Kod Yapısı

Form1.Designer.cs:

Tüm PictureBox ve Label bileşenlerinin tanımları

Timer ve event bağlamaları

Form1.cs:

Oyun mantığı (gravity, skor, boru hareketi)

Event handler’lar (KeyDown, KeyUp, TimerTick)

Restart butonunun oluşturulması ve işlevi

6. Görseller ve Kaynaklar

Tüm görseller Resources veya proje içi dizine eklenmelidir.

Kuş: flappyBird.png

Alt Boru: BoruAlt.png

Üst Boru: BoruUst.png

Zemin: zemin.png

7. Geliştirme ve Gelecek Planları

Kuş animasyonu eklemek

Boru aralıklarını rastgele yapmak

Ses efektleri ve arka plan müziği eklemek

Skor tablosu ve yüksek skor kaydı

Mobil veya web versiyonunu yapmak

8. Lisans

Bu proje açık kaynaklıdır. Kullanım, kopyalama ve paylaşım serbesttir.
Geliştiren: Beyzanur KARADEMİRLİ
