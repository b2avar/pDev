# PROJE-2 : Console ToDo Uygulaması


Yeni bir console uygulaması açarak bir 3 kolondan oluşan bir TODO uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.



- Kart Ekle
- Kart Güncelle
- Kart Sil
- Kart Taşı
- Board Listeleme


## Kart İçeriği:



- Baslık
- Icerik
- Atanan Kisi (Takım üyelerişnden biri olmalı)
- Büyüklük (XS, S, M, L, XL)


## Açıklama:



- Board TODO - IN PROGRESS - DONE kolonlarından oluşmalı.


- Varsayılan olarak bir board tanımlı olmalı ve 3 tane de kart barındırmalı.(Kartlar herhangi bir line'da yani kolonda olabilir.)


- Kartlar ancak takımdan birine atanabilir. Takımdaki kişiler ise varsayılan olarak tanımlanmalı. Takım üyeleri Dictionary kullanılarak key-value pair şeklinde ya da bir sınıf aracılığıyla tutulabilir. Kartlara atama yapılırken takım üyeleri ID leri ile atanacak. Yani kullanılacak yapının mutlaka bir ID içermesi gerekir.


- Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.

```
  Lütfen yapmak istediğiniz işlemi seçiniz :) 
  *******************************************
  (1) Board Listelemek
  (2) Board'a Kart Eklemek
  (3) Board'dan Kart Silmek
  (4) Kart Taşımak
```
### (1) Board Listelemek

```
 TODO Line
 ************************
 Başlık      :
 İçerik      :
 Atanan Kişi :
 Büyüklük    :
 -
 Başlık      :
 İçerik      :
 Atanan Kişi :
 Büyüklük    :
 
 
 IN PROGRESS Line
 ************************
 Başlık      :
 İçerik      :
 Atanan Kişi :
 Büyüklük    :
 -
 Başlık      :
 İçerik      :
 Atanan Kişi :
 Büyüklük    :


 DONE Line
 ************************
 ~ BOŞ ~
 ```
### (2) Board'a Kart Eklemek

```
 Başlık Giriniz                                  : 
 İçerik Giriniz                                  :
 Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :
 Kişi Seçiniz                                    : 
```
- Büyüklükler Enum olarak saklanmalı. Kart üzerinde gösterilirken XS olarak gösterilmeli. Giriş yapılırken kullanıcıdan 1 alınmalıdır.
- Takım üyeleri mevcut bir listede daha tanımlanmış olamlıdır.(Program içerisinde dinamik tanımlanmasına gerek yok.) Kart tanımlarken takım üyesinin ID'si istenmeli. Tanımlı bir ID değilse "Hatalı girişler yaptınız!" uyarısı ile işlem iptal edilebilir.

### (3) Board'a Kart Silmek

```
Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.
Lütfen kart başlığını yazınız:
```


