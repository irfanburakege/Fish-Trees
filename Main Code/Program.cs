using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;

namespace proje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //balıkların bilgisini içeren text
            string text = "1. Akya Balığı\n\nCarangida familyasının bir üyesi olan akya balığı, boyutları ve zevkli avcılığı ile olta balıkçılarının avlanırken en çok heyecanlandığı deniz balıklarından biridir. Akya olarak bilinen bu tür, aynı zamanda liça balığı olarak da adlandırılır.\n\nMaksimum yetişkin boyutları, 200 cm uzunluk ve 50 kg ağırlıktır. Ancak, genellikle Ege denizinde bulunanların 120 cm civarına kadar büyüdükleri görülmüştür.\n\nÜreme dönemleri olan Mayıs ve Ağustos arasında yumurtlamak için gittikleri nehir birleşimlerinde kefaller ve sardalyaları yiyerek güç toplarlar. Ana besinleri kefal yavrularıdır.\n\nNehir ağızlarına yakın alanlarda daha küçük boyuttakiler bulunurken büyük boyutlu akyalar, 40-50 metre derinlikte ve kıyıya uzak olmayan alanlarda yaşar.\n\n2. Yaygın Aslan Balığı (Şeytan ateş balığı)\n\nHint-Pasifik bölgesine özgü bir aslan balığı varyantı olan bu tür, bilimsel olarak Pterois miles olarak adlandırılmıştır. Benzerlikleri dolayısıyla kırmızı aslan balığı ile karışıtırılırlar.\n\nHint-Pasifik bölgesinin yanı sıra ülkemiz sularından Ege denizinde de yaşadıkları biliniyor. Genel aslan balığı çeşitleri gibi bu tür de zehirli bir türdür.\n\nSırtında toplamda 13 adet diken bulunur. Renkleri kırmızı, gri veya ten rengi tonlarındadır. Geceleri avlandıklarından gündüzleri pek aktif bir tür değillerdir. Küçük kabuklular ve balıklar ile beslenirler.\n\nYetişkin boyutları 35 cm’ye kadar ulaşabilir. Ege balıkları arasında olsalar da yaygın olarak Kızıldeniz’de ve Endenozya sularında görülürler.\n\n3. Barbunya (Barbun)\n\nGerçek adı Barbunya balığı olsa da halk arasında Barbun adı ile bilinir. Mullidae familyasından olan bu türe Mullus barbatus bilimsel adı verilmiştir.\n\nEge denizi gibi sıcak ve ılıman suların kıyıya yakın kumlu ve çamurlu bölgelerinde yaşarlar. Nadiren de olsa kayalık alanlarda görülmektedirler. Tekir balığına benzerlikleri ile bilinirler. Aradaki farkı anlamak için burun, göz altı ve sırt yüzgecine bakılmalıdır.\n\nMaksimum boyutları 40 cm’dir ancak, Ege Denizi bölgesindekiler genellikle 18-20 cm civarında olurlar. Ege balıkları arasında ticari öneme sahip, eti lezzetli balıklardandır.\n\n4. Çipura\n\nÇipura balığı diğer adıyla Çupra, Ege denizi balık türleri arasında yer alsa da aslında Akdeniz bölgesinde de yaşarlar.\n\nIlıman sulara sahip bölgelerin, kumlu ve çamurlu bölgelerinde yaşarlar. Zaman zaman nehir ağızları ve lagünlerde bulundukları da olur.\n\n200 gr ve üzeri olanlar Çipura, bunun altında olanlar ise Lidaki olarak isimlendirilir. Kuvvetli bir çeneye sahiptir ve bu sayede kabukluları kolayca yiyebilir.\n\nAvlanmak isteniyorsa yaz aylarında kıyıya yakın, kış aylarında 30-40 metre derinlikte avlanabilirler. Kışın boyut olarak daha iri Çipuralar daha derin noktalara inerler. Ticari değeri yüksek ve eti oldukça lezzetli ege denizi balıklarındandır.\n\n5. Çitari (Sarpa)\n\nGörüntü olarak Çipura balığına çok benzerdir. Halk arasında Sarpa balığı olarak bilinirler. Yüzeyden 70 metre derinliğe kadar uzanan yaşam alanları vardır.\n\nMaviye çalan gri renkli üst kısımları, gümüş renkli yan kısımları vardır. Maksimum olarak 51 cm uzunluk ölçülmüş olup, genellikle 15-30 cm civarında görülürler.\n\nEge denizi balık türleri arasında ticari değeri yoktur. Yapılan araştırmalarda tam olarak tespit edilemese de balığın tükettiği bir alg neticesinde, sarpa yiyen insanlarda halüsinojenik balık sarhoşluğu denilen rahatsızlığa sebep olur.\n\n6. Çizgili Hani Balığı (Yazılı Hani)\n\nHani balığı, Orfoz’un da içinde bulunduğu Serranidae familyasından ve Levreğin içinde bulunduğu Serraninae alt türünden bir balıktır. Bilimsel adı Serranus scriba’dır. Çizgili hani balığı Ege denizi balıkları arasında yer almaktadır ancak hani balıkları genel olarak Akdeniz ve Karadeniz’de yaygındırar.\n\nÜlkemiz denizlerinden Ege Denizi’ne özgü Çizgili hani, 5 ila 150 metre arasında yaşam alanına sahiptir. Gündüzleri kayalıkların oluşturduğu mağaralarda geçirirken, alacakaranlık ve geceleri avlanmak için ortaya çıkar.\n\nGenellikle yalnız yaşadıkları görülse de küçük sürüler halinde yüzdüklerine de rastlanmaktadır. Uzunlukları en fazla 25 cm’ye ulaşır. Kabuklular, kafadanbacaklılar ve küçük balıklar ile beslenir. Ticari değeri olmayan, eti lezzetli Ege balıklarından biridir.\n\n7. Dikenli vatoz\n\nDikenli vatoz, Dasyatidae familyasından bir vatoz balığı türüdür. Akdeniz ve Karadeniz bölgelerimizde de görülen bu tür, daha fazla görülmesi sebebiyle Ege Denizi balık türleri arasında bulunmalıdır.\n\nÇok derin sularda değil, genellikle 60 metre civarı derinlikte ve çamurlu alanlarda yaşarlar. Ana besinleri dipte yaşayan kabuklu türleridir. Ek olarak yumuşakçalar, solucanlar ve küçük balıklarla da beslenir.\n\nEge denizinde bulunan dikenli vatozlar, genellikle 40-45 cm civarında veya daha küçük boyuttadır. Tırtırlı kuyruk ve iğneleri yüzünden insanlar için tehlikeli balık türleri arasındadır. Ticari değeri yoktur.\n\n8. Eşkina\n\nEşina balığı, Sciaenidae familyasından bir deniz balığı türüdür. Bilimsel adı Sciaena umbra olan bu tür, Akdeniz ve Ege Denizi bölgelerimizde bulunmaktadır. Eşkina balığı amatör avcılık yapanların sıklıkla karşılaştığı bir türdür.\n\nYavru eşkinalar kıyı şeritlere yakın nehir ağızlarında yaşarken, yetişkinler 5 metre ile 200 metre arasında yaşarlar. Ege balıkları listemize dahil ettiğimiz eşkina, en fazla 60 cm boyuta ulaşabilir ancak, ülkemiz sularında genellikle 30-40 cm civarında görülürler.\n\nBu balığı sıradışı kılan bir özelliği de vardır. Balığın kafasından, alın bölgesinden 1 cm çapında taş çıkar. Bilimsel olarak kanıtlanmamış olsa da bu taş limon ile eritilerek tüketildiğinde böbrek taşı rahatsızlığına iyi geldiği düşünülür.\n\nTicari değer açısından orta seviyelerdedir. Genellikle balık lokanlarında servis edilen, lezzetli bir türdür.\n\n9. Horozbina Balığı\n\nHorozbina, Blenniidae familyasından 900 civarı alt türe sahip, hem tuzlu hem de tatlı sularda (küçük bir bölümü) yaşayan alt varyantlara sahip balık türlerinin ortak adıdır.\n\nHorozbina tür adı altında 150 farklı cins ve 900 civarı da varyant tanımlanmıştır. Tatlı su blennysi olarak bilinen bir türü, nadiren de olsa akvaryumlarda beslenmektedir.\n\nGenellikle küçük boyutlara sahip olabilen bu balığın, yılan balığına benzer varyantlarıyla 55 cm boyutuna ulaştığı görülmüştür. İri bir göz ve ağız yapısına sahiptir.\n\nZamanlarının büyük kısmını deniz tabanında ve kayalık yarıklarında geçirirler. Ticari değeri olmayan, Akdeniz ve Ege Denizi balıklarından biridir.\n\n10. İskaroz (Papağan Balığı)\n\nGenellikle ılıman ve sıcak sulara sahip denizlerde yaşarlar. Bilimsel adı Sparisoma cretense olan tür Scaridae familyasındandır.\n\nParlak renklere sahip bir balıktır. Görünüşü itibariyle sazan balığının tropik halini andırır. Papağan isminin verilmesi ağızlarının papağan gagasına benzemesindendir.\n\nErkekler daha koyu tondaki renklere sahipken dişiler, kırmızı-turuncu tonlarındadır. Zamanlarının çoğu mercan resiflerinde geçer. Burada deniz yosunu ile beslenirler.\n\nYetişkin dönemlerinde en fazla 50 cm olabilirler ancak, ülkemizdeki iskaroz balıkları 20-30 cm civarındadır. Ticari değeri bulunmayan iskarozun eti orta lezzettedir.\n\n11. İskorpit Balığı\n\nİskorpit, Ege balıkları arasında zehirli türlerden biridir. Yüzgeçlerinde bulunan dikenlere dokunulduğunda kişiyi zehirler ve bölgede kızarıklık, şişlik görülür.\n\nBu etki 2-3 gün devam eder. Amonyak kullanılarak tedavi edilebilir. Özellikle amatör balıkçılar tarafından kırlangıç balığı ile karıştırılıp yaralanmalara sebep olmaktadır. Tutulduğunda dikenlerine dokunmamaya dikkat edilmelidir.\n\nKayıt edilmiş maksimum uzunluk 37 cm iken, ülkemiz sularında yetişkin olanları 20-25 cm civarında görülürler. Akdeniz, Karadeniz ve Ege denizi balık türlerinden biridir.\n\nİskorpit, zehirli balıklardan biri olsa da eti lezzetli olan ve barındırdığı vitamin ve yağlar ile insan sağlığına çok yararlı bir balıktır.\n\n12. İsparoz (İspari Balığı)\n\nSparidae familyasından olan isparinin bilimsel adı Diplodus annularis’dir. Bu balık genellikle ılıman sahil bölgelerine yakın alanlarda yaşar. Ege balıklarından biridir ve diğer denizlerimizde de bulunur.\n\nMaksimum 25 cm uzunluğa erişebilirler. Ülkemiz sularında 15-18 cm civarında ispariler bulunur. Sportif balıkçılıkta sevilen bir balık türüdür. Genç olanları kışın lagünlere giderek beslenirler. Karides, yavru balıklar ve kurtçuklar ana besinleridir.\n\nTicari değeri düşüktür ve genellikle olta balıkçılığı ile avlanırlar. Eti lezzetli ve az kılçıklı bir balıktır.\n\n13. İzmarit Balığı (İstrongilos)\n\nİzmarit balığı, Ege denizi balık türleri arasında yer alıyor ancak Akdeniz bölgelemizde daha yaygın bulunur. Bilimsel adı Spicara smaris olan izmarit, Sparidae familyasından bir deniz balığı türüdür.\n\nIlık sulara sahip bölgelerin kayalık, çamurlu dip kısımlarında yaşamaktadır. En fazla 25 cm boyutuna (erkekler) ulaşan bu tür, ülkemizde genellikle 15 cm civarında görülür.\n\nÜlkemiz sularında iki tür izmarit yaşamaktadır; İstargilos ve Menekşe izmarit. Eti lezzetli bir balıktır ve genellikle önce pişirilip sonra ayıklanır.\n\n14. Kalkan Balığı\n\nKalkan balığı (Scophthalmus maximus), gözleri vücudunun solunda olan, Scophthalmidae familyasından bir deniz balığı türüdür. Vücudunun sağını deniz tabanına yatmak için kullanır.\n\nÜlkemizin tüm denizlerinde yaşayan bir türdür. Yaşam alanları 20 metre ile 70 metre arasındadır. Tipik balık türlerinden farklı olarak yuvarlak bir vücuda sahiptir. Maksimum 1 metre uzunluğa erişebilirler. Ülkemiz denizlerinde ise yetişkinler 60-70 cm civarında görülür.\n\nHenüz yavruyken gözleri sağda ve solda ayrı durmaktadır. 8-10 cm civarına ulaştıklarında sağ göz vücutlarının sol tarafına kaymaya başlar.\n\nTicari değeri yüksek, eti çok lezzetli ege balıkları arasındadır.\n\n15. Karagöz Balığı\n\nKaragöz balığının Çipura ile yakın akrabalığı bulunmaktadır. Sarmos, mırmır, sivri gaga gibi birkaç çeşidi vardır.\n\nMaksimum 50 cm boyutuna ulaşabilir. Ülkemizde Akdeniz, Karadeniz ve Ege Denizi bölgelerimizde yaşarlar. Bu bölgelerde yaygın olarak 25 cm civarında görülür. Kayalık, kumlu alanlarda yaşarlar.\n\nGörünüşü ile Çupra balığına benzemesinin yanı sıra lezzet olarak da benzerdir. Serin dönemlerde tüketimesi tavsiye edilir bu dönemlerde eti daha yağlı ve lezzetli olmaktadır.\n\n16. Kolyoz Balığı\n\nUskumsugillerden olan kolyoz, Scombridae familyasından bir deniz balığıdır. Uskumruya çok benzeyen bir balıktır. Kuyruk yüzgecine bakılarak ayırt edilebilir. Bu türün kuyruk yüzgecinin ucu daha sivridir.\n\nGenç olanlar kıyılara yakın kumlu alanlar ve yosun yataklarında yaşarken, yetişkin olanlar daha açıkta derin sularda yaşar.\n\nSürüler halinde yaşamlarını sürdürürler. En fazla 50 cm uzunluğa kadar büyüyebilir ancak ülkemiz sularında görülen yetişkinler ortalama 20-25 cm civarındadır. Eti lezzetli ege balıkları arasındadır.\n\n17. Kırma Mercan\n\nKırma mercan balığı (Pagellus erythrinus) çipura ailesinden, Sparidae familyası mensubu, Akdeniz ve Ege balıklarından biridir. Özellikle Akdeniz ülkelerinde bolca tüketilen lezzetli bir balık türüdür.\n\nİnce, oval yapıda bir vücuda sahip olan kırma mercan en fazla 50 cm boyutuna ulaşabilir. Genel olarak 15-30 cm arasında görülürler. Bu tür bir hermafrodittir; sonradan cinsiyet değiştirebilirler.\n\nGenellikle hayatlarının ilk yıllarında dişi, sonraki yıllarında ise erkek olurlar. Hepçil bir balıktır ve ana besinleri küçük balıklar ve omurgasızlardan oluşur. Akdeniz ülkelerinde ticari değere sahip, lezzetli bir balıktır.\n\n18. Lahoz Balığı (Grida balığı)\n\nLahoz balığı Hani balıkları ailesinden, Ege ve Akdeniz bölgelerinde bulunan bir türdür. Bu tür iri ege balıkları arasındadır. En fazla 125 cm uzunluk ve 25 kg ağırlığa ulaşabilirler.\n\nPeople Also Read  Ters Yüzen Çöpçü\nYaşam alanları 20-250 metre arasında kayalık, çakıllı ve taşlı alanlardır. Son derece yırtıcı etçil balıklardan biridir. Yiyebileceği her türlü balık, omurgasız ve kabuklu türleri ile beslenir.\n\nOrfoz balığı ile yakından akrabadır ve ticari değeri bulunduğu bölgeye göre değişir. Özellikle Akdeniz bölgesinde etinin lezzetli ile bilinir.\n\nBu tür birkaç farklı isimle bilinir.\n\n19. Levrek\n\nBirçoğumuzun da yakından tanıdığı Levrek balığı, Dicentrarchus familyasından bir balık türüdür. Bilimsel olarak ilk kez 1758 yılında Dicentrarchus labrax olarak tanımlanmıştır.\n\nŞimdiye kadar kayıt altına alınan en büyük boyutları 1m ve 12 kg olsa da yaygın olarak 50 cm ve 5 kg civarında görülürler. Akdeniz ve Ege başta olmak üzere tüm denizlerimizde yaşadıkları biliniyor.\n\nHaliçler, lagünler, akarsuların denize döküldüğü yerler ana yaşam alanlarıdır. Kısa bir süreliğine tatlı sulara geçtikleri de bilinmektedir (tatlı su levreklerinin dışında).\n\nTicari değeri yüksek, etinin lezzetini kanıtlamış Ege denizi balık türlerinden biridir.\n\n20. Lipsoz Balığı\n\nLipsoz balığı, görünümü ile iskorpit balığına benzeyen Scorpaenidae familyasından bir balık türüdür. Lipsos ismiyle de bilinen bu türün bilimsel adı Scorpaena scrofa’dır.\n\nÜlkemiz sularında Akdeniz ve Ege Denizi türlerinden biridir, Karadeniz bölgesinde bulunmaz. S. porcus türü Karadeniz bölgesinde görülebilir. İskorpit balığı gibi bu balık da zehirli balıklardan biridir.\n\nVücut rengi kiremit rengi tonlarından, pembemsi tonlara kadar değişebilir. En fazla 50 cm ve 3 kg ağırlığa ulaştığı biliniyor ancak, sularımızdaki yetişkin lipsoz balıkları genellikle 25-30 cm civarındadır.\n\nYenilebilir balıklardan biridir, en çok çorba ve buğulama yapıldığında lezzetlidir.\n\n21. Lüfer Balığı\n\nLüfer,  Pomatomidae familyasından bir balık türüdür. Ege balıkları arasında ekonomik değeri yüksek ve çok lezzetli bir balıktır. Bilimsel adı Pomatomus saltatrix olan lüfer, ülkemizin tüm denizlerinde bulunmaktadır.\n\nMaksimum ölçülen boyutları 120 cm ve 14 kg’dır. Bölgemizde yaşayan yetişkin lüferler 30-60 cm arasında bulunurlar. Lüfer, gevşek ve küçük gruplar halinde yaşayan yırtıcı deniz balıklarından balıklardan biridir.\n\nLüfer çeşitli boyutlara göre farklı isimler almıştır:\n\nSarıkanat: 18 – 25 cm boyutlarında olan lüfer yavrusudur. 18 cm altının avlanması veya satılması yasaktır.\nLüfer: 28 – 35 cm boyutlarına ulaştığında lüfer adı verilir. Avlamak ve satış serbesttir.\nKofana: 35 cm üzerine çıkan lüferlere bu ad verilmiştir. Avlanması ve satılması serbesttir.\nSırtıkara: 50 cm’nin üzerindeki lüferlere verilmiş isimdir. Ülkemiz denizlerinde uzun süredir görülmemiştir. Avlamak ve satışını yapmak serbesttir.\nLüfer bir dönem koruma altına alınarak avlanılması ve satışı yapılması yasaklanmış balık türlerindendir. Ancak, günümüzde yasak bitirilerek 18 cm ve üzeri olanların avlanması ve satılması serbest bırakılmıştır.\n\n22. Mahmuzlu camgöz köpek balığı\n\nMahmuzlu camgöz Squalidae familyasından, Akdeniz ve Ege Denizi başta olmak üzere ülkemiz sularında bulunmaktadır. Ülkemizde tüketilmese de Avrupa ülkelerinde tüketildiği bilinmektedir.\n\nAna besinleri balık sürüleri ve ahtapotlar olan bu türün, profesyonel balıkçıların ağlarına ciddi hasar verdiği biliniyor. Nadiren de olsa dip balıklarını avlayan amatör balıkçıların oltasına takıldığı görülmektedir.\n\nEn fazla 150 cm ve 10 kg boyutlarına eriştikleri tespit edilmiştir ancak, genellikle 80 cm ve 4 kg civarlarına ulaşırlar. Ticari değeri yoktur.\n\n23. Mandagöz Mercan Balığı\n\nKırmızı (kızıl) çipura olarak da bilinen mandagöz mercan (Pagellus bogaraveo) Sparidae familyasından bir deniz balığıdır.\n\nAkdeniz başta olmak üzere ılıman ve sıcak denizleri tercih eden bir türdür, ılıman ısısıyla Ege balıklarından da biridir. Bulunduğu bölgeye göre en fazla 400 ila 700 metre derine inebilen bir balıktır.\n\nKaydedilen en büyük uzunluk 70 cm, yaygın olarak da 30 cm ve 4 kg’dır. Eti lezzetli, ızgarada pişilmesi tercih edilen bir mercan varyantıdır.\n\n24. Melanur Balığı (Melanurya)\n\nMelanur diğer adıyla Melanurya, Sparidae familyasından bir deniz türüdür. Ülkemizde Akdeniz, Marmara ve Ege bölgerinde bulunur. Bilimsel adı Oblada melanura olan melanur, Ege denizi balık türleri arasında yer alıyor.\n\nÇok iri boyutlara ulaşabilen bir tür değildir. Kaydedilen maksimum boyutları, 38 cm ve 930 gr’dır. Ülkemiz sularında yaygın olarak 20 cm civarında görülürler. Hepçil olan türün ana besini omurgasızlardır.\n\nEti lezzetli türlerden biri olan melanurun ticari değeri orta seviyelerdedir.\n\n25. Mersin Balığı\n\nMersin balığı birçok farklı türün ortak adıdır. Mersin balığı adı altında 19 farklı cins balık bulunmaktadır. Görünümlerindeki ufak farklılar ile ayrılırlar. Bu balıklar Acipenseridae familyasına aittir. Akdeniz bölgemizde daha yaygın olan tür, Ege balıkları arasında da bulunmaktadır.\n\nTüre göre boyutları farketmektedir. Yetişkin mersin balıkları ortalama 140 ila 300 cm uzunluğa, 100 ila 200 kg ağırlığa ulaşabilirler. Şimdiye kadarki ölçülen en büyük boyutlar; 7.2 metre ve 1571 kilogramdır.\n\nMersin balığı altında bulunan 19 farklı tür şu şekildedir:\nSibirya mersini\nKısa burunlu mersin balığı\nYangtze mersin balığı\nGöl mersin balığı\nRus mersin balığı\nYeşil mersin balığı\nSakhalin mersin balığı\nJapon mersin balığı\nAdriyatik mersin balığı\nŞip balığı\nKörfez mersinbalığı\nAtlantik mersin balığı\nİran mersin balığı\nÇuka balığı\nAmur mersin balığı\nÇin mersin balığı\nYıldızlı mersin balığı\nKolan balığı\nBeyaz mersin balığı\n\n26. Mürekkepbalığı\n\nMürekkepbalığı Cephalopoda (Kafadanbacaklılar) sınıfından, deniz türleri arasında olan bir yumuşakça türüdür. İkisi diğerlerinden daha uzun olan toplam 10 adet kolları vardır ve iç bölgelerinde çok sayıda vantuz bulunur.\n\nEge denizi balıkları arasında yer alan mürekkepbalığı, sıcak sularda yaşayan bir türdür. Bu türün boyutları çok değişkendir. Cinse göre 20 cm ile 17 metre arasında değişen çeşitleri vardır. Yaygın olarak yetişkin olanları 50-60 cm arasındadır.\n\nTicari değeri olan, eti lezzetli bir yumuşakça türüdür.\n\n27. Mırmır Balığı\n\nSparidae familyasından olan mırmır balığı, ekonomik değeri yüksek lezzetli balık türlerinden biridir. Denizin diplerinde ve kumlu kısımlarda yaşayan mırmır balığı sıklıkla avlanan Ege balıkları arasındadır.\n\nPeople Also Read  Akvaryum Balık Hastalıkları: 9 Yaygın Hastalık ve Tedavileri - 2023\nÜlkemizde Ege, Akdeniz ve Marmara bölgelerinde bolca bulunurlar. Ana besinlerini kabuklular, solucanlar ve yumuşakçalar oluşturur.\n\nEn fazla 55 cm ve 1 kg ağırlığa ulaşmaktadırlar ancak, yaygın boyutları 30 cm civarındadır. Ticari değeri yüksek Ege denizi balık türlerinden biridir.\n\n28. Orfoz Balığı\n\nSerranidae familyasından Orfoz, Taş hanisi adıyla da bilinir. Bilimsel adı Epinephelus marginatus’dur. Orfozlar hermafrodit (çift cinsiyetli) deniz balıkları arasındadır.\n\nOrfoz balığı neslinin tükenmesiyle karşı karşıya olduğu için avlanması yasak türlerdendir. Ülkemizde Akdeniz ve Ege denizlerinin güney kısımlarında yaşarlar.\n\nEn fazla 140 cm ve 60 kg boyutlarına ulaşabilirler. Boyutları ile iri ege balıklarından biridir. Ülkemiz denizlerinde yaygın görülen boyutları ortalama 60 cm ve 15 kg’dır.\n\n29. Orkinos (Ton balığı)\n\nÇoğumuzun marketlerde konserve içerinde gördüğü Orkinos, Uskumrugiller (Scombridae) ailesinin üyesidir. Kendi aralarında farklı türlere sahip olan, Orkinos ortak adı verilen bu balık denizlerdeki en iri balıklardan biridir.\n\nEge denizi balıkları arasında en büyük türlerden biridir. Yetişkin bir ton balığı, 6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır. Ancak, bu boyutlarda Orkinos bulma ihtimali çok düşüktür genellikle 3-4 metre ve 400-600 kg arasında avlanırlar.\n\nEkonomik değeri çok yüksek ve son deree lezzetli balıklardandır.\n\n30. Pisi Balığı\n\nPisi balığı kalkan ile karıştırılabilir ancak resimlerine bakıldığında kolayca ayırt edilebilir. Pleuronectidae familyasından olan pisi balığının vücudu kalkana göre daha elips şeklindedir ve kalkanın sırtında olan düğme diye tabir edilen kemikli yapılar yoktur.\n\nYine pisi balığının gözleri de vücudun sağ tarafındadır. En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır.\n\nÜlkemizde Akdeniz, Ege, Karadeniz ve Marmara bölgelerimizde bulunur.\n\n31. Sardalya Balığı\n\nSaldalya hamsi ile yakından akraba, Clupeinae familyasından bir balık türüdür. Sürüler halinde kıyıya yakın geçerek göç ederek yaşamlarını sürdürürler.\n\nAkdeniz ve Karadeniz’de daha yaygın görülen sardalya, Ege denizi balık türleri arasında da yer almaktadır. Denizlerimizde 15-20 cm boyutlara ulaşırlar ancak okyanus bölgelerindeki sardalyalar 30 cm uzunluğa kadar büyümektedir.\n\nTicari değeri çok yüksek, lezzetli balık türlerindendir.\n\n32. Sargan Balığı (Zargana)\n\nTipik balık görünümünün dışında uzun ve ince bir vücuda sahip sargan (Belone belone), Belonidae familyasının üyesidir. Vücut yapıları sayesinde hızlı ve çevik deniz balıklarındandır.\n\nYaşadıkları bölgeye göre 1 metre uzunluğa erişmektedirler ancak Akdeniz ve Ege denizlerimizde 60 cm civarına kadar büyümektedirler.\n\nAna besinleri küçük balıklardır ve hamsi, çaça gibi balık türleri ile beslenir. Ticari değeri yüksek, lezzetli Akdeniz ve Ege balıkları arasındadır.\n\n33. Sargoz Balığı\n\nSargoz, Akdeniz ve Ege bölgelerinde sıklıkla Karagöz ile karıştırılır. Diplodus sargus bilimsel adı verilmiştir ve Sparidae ailesinden bir deniz balığı türüdür.\n\nBu balık bölgeye göre farklı isimler almıştır. Baltabaş, Sargos ve Ak Karagöz olarak da bilinirler. Ülkemizde Akdeniz ve Ege bölgelerimizde yaygındır.\n\nGüçlü çeneye sahiptirler ana besinleri; kabuklular, yumuşakçalar ve deniz yosunları. Ekonomik değeri yüksek, lezzetli bir balıktır.\n\n34. Sinarit Balığı\n\nSparidae familyasından olan Sinarit’in bilimsel adı Dentex dentex’dir. Akdeniz’de yaygındır ancak Karadeniz, Marmara ve Ege balıkları arasında da yer alırlar.\n\nTaşlı ve kumlu bölgelerde 200 metre derinliğe kadar yaşarlar. Ana besinleri kafadanbacaklılar ve yumuşakçalardır. Genellikle yalnız yaşarlar ancak üreme dönemlerinde küçük sürüler halinde görülmektedirler.\n\n1 metre uzunluğa, 20 kg ağırlığa ulaşırlar. Olta avcılığı son derece zevkli, eti lezzetli ama az bulunan bir balıktır.\n\n35. Tekir Balığı\n\nBilimsel adı Mullus surmuletus olan Tekir, Mullidae familyasından bir deniz balığıdır. Akdeniz, Karadeniz ve Ege denizi balık türleri arasındadır.\n\n5 metrelik sığ sulardan 400 metre derinlikteki sulara kadar uzanan yaşam alanları vardır. Kaydedilmiş en büyük boyutları 40 cm ve 1 kg’dır ancak sularımızda yaygın olarak 25 cm civarında görülürler. Ticari değeri olan bir balıktır ve av balığı olarak da kullanılmaktadır.\n\n36. Trakonya Balığı\n\nTrakonya balığı halk arasında dragon balığı olarak da bilinmektedir. Trachinidae ailesinden olan balığın bilimsel adı Trachinus draco’dur.\n\nVücudunda zehirli dikenlere sahiptir ve dokunulduğunda toksik bir madde salgılar. Zehirli Ege balıkları arasındadır. Zehri kuvvetlidir, uzuv kaybı veya kalp krizine neden olabilmektedir.\n\n1 metre ile 150 metre arasında kumlu, çakıllı alanlarda yaşamaktadır. Küçük balıklar, omurgasızlar ve kabuklular ana besinleridir. En fazla 55 cm boyuta ulaşabilirler ve genellikle 25 cm civarında görülürler. Ticari değer yoktur.\n\n37. Trança\n\nEge balıkları arasında meşhurlaşmış türlerden biridir. Bölgede Çavuş, Antenli mercan, Altınkaş isimleri ile de bilinir. Bilimsel adı Pagrus caeruleostictus’dur ve mercan familyasından bir türdür.\n\nSığ ve sıcak sularda tek olarak yaşayan iri bir balıktır. Etçil bir balıktır ve kafadanbacaklılar, küçük balıklar ana besinleridir. Okyanuslara ve farklı denizlere sürekli göç eden balıklardandır.\n\nYetişkin boyutları 60-75 cm civarındadır ancak 1 metre üzerine de çıkabilmektedir. Ekonomik değeri yüksek, lezzetli bir balıktır.\n\n38. Zurna Balığı\n\nZurna balığı (Scomberesox saurus), Scomberesocidae familyasından bir deniz balığıdır. Açık denizlerde yaşayan bu tür, Süveyş kanalının açılmasından sonra Akdeniz ve Ege denizlerinde görülmüştür.\n\nEn fazla 50 cm, ortamala 35 cm boyutlarındadır. Balık yavruları ve plankton ile beslenir. Avlanmadıkları için herhangi bir ticari değeri yoktur.";

            string[] BalıklarAyrılmış = BalıkStringleriniAyırma(text);//balıkları 1. 2. olarak stringlere ayıran methodu çalıştırma

            List<EgeDeniziB> balıkListesi = new List<EgeDeniziB>();// Balık generic list oluşturma

            for (int i = 0; i < BalıklarAyrılmış.Length; i++)//balıkları EgeDeniziB objesi haline getirip listeye atma döngüsü
            {
                EgeDeniziB balık = BalıkClassOluştur(BalıklarAyrılmış[i]);// balık nesnesi oluşturma
                balıkListesi.Add(balık);
            }
            BinaryTreeBalık BalıkAğacı = new BinaryTreeBalık();//balık ağacı oluşturma
            foreach (EgeDeniziB b in balıkListesi)//balıkListesindeki elemanlar balık ağacına ekleniyor
            {
                BalıkAğacı.Insert(b);
            }

            Console.WriteLine("BALIK AĞACI INORDER(ALFABETİK): ");
            Console.WriteLine();
            BalıkAğacı.PrintInOrder();//ağacı inorder yazdırma
            Console.WriteLine();

            OrtalamaDerinlikBulYazdır(BalıkAğacı);//tüm kelime ağaçlarının ortalama derinliğini bulan methodu çalıştırma
            Console.WriteLine();
            Console.Write("Yazdırmak istediğiniz harf aralığını giriniz(XY şeklinde bitişik olarak tek satırda): "); // verilen aralıktaki balıkları yazdırma
            string input = Console.ReadLine();
            char start = input[0];
            char end = input[1];
            BalıkAğacı.ArasınıYazdır(start, end);
            Console.WriteLine();

            EgeDeniziB[] balıkArray = BalıkAğacı.ToArray();//alfabetik sıradaki balıkArrayi
                    
            BinaryTreeBalık dengeliBalıkAğaç = DengeliAğaçOluştur(BalıkAğacı,balıkArray);//dengeli balık ağacı oluşturma
            Console.WriteLine("Dengeli Balık Ağaç postOrder: ");
            dengeliBalıkAğaç.PrintPostOrder(dengeliBalıkAğaç.getRoot());//postorder isimleri yazdırarak çalıştığını görme

            Hashtable balıkHash = new Hashtable(); // balıklar hashtable
            HashTableEkle(balıkHash, balıkArray);   // arraydeki balıkları alfabetik hashTable ekle
            Console.WriteLine("Balık HashTable: ");
            foreach(string ad in balıkHash.Keys) { Console.Write(ad+", "); }
            Console.WriteLine();
            HashParagrafDeğiştir(balıkHash);    // adı verilen balığın bilgi paragrafını değiştirme
            Console.WriteLine();
             

            MaxHeap balıkHeap = new MaxHeap(38); // balık Max Heap oluşturma
            foreach (EgeDeniziB b in balıkArray)
            {
                balıkHeap.Ekle(b); // balık arrayindeki balıkları heape ekleme
            }
            Console.WriteLine("Balık Heap ilk 3 eleman: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(balıkHeap.Sil().ToString());
            }
            Console.WriteLine();
        }

        static string[] BalıkStringleriniAyırma(string text)// text dosyasını sıralamaya göre ayıran method
        {
            string[] BalıklarAyrılmış = new string[38];// son array

            for (int i = 1; i < 39; i++)
            {
                int index1 = 0, index2 = 0;
                if (i < 10)//s sıralama sayısına eşit ise ("1." den "9." kadar) indexleri alınıyor
                {
                    index1 = text.IndexOf(i + ".") + 2; //2 ekleyerek baştaki sayıyı atıyoruz ve aradığımız sayının başlama indexini buluyoruz
                    index2 = text.IndexOf((i + 1) + ".") - 4;
                }
                else if (i < 38)//10,11....37
                {
                    index1 = text.IndexOf(i + ".") + 3; // 4 ekliyoruz çünkü sayılar çift basamaklı ve 1 boşluk da siliyoruz aynı hizada olmaları için
                    index2 = text.IndexOf((i + 1) + ".") - 4;//sonraki sayının başladığı index \n\n çıkarmak için 4 çıkarıyoruz
                }
                else //38. eleman için
                {
                    index1 = text.IndexOf(i + ".") + 3;
                    index2 = text.Length - 1;//39. eleman olmadığı için sona kadar gidyoruz
                }

                int length = index2 - index1 + 1;//text parçasının uzunluğu
                BalıklarAyrılmış[i - 1] = text.Substring(index1, length);
            }
            return BalıklarAyrılmış;
        }

        static string[] AdAyırma(string adSatırı)//iki adı varsa diğer adı alınıyor
        {
            string[] AdSatırı = adSatırı.Split('(');//eğer ( varsa ayırılıyor
            string[] AdSatırıAyrılmış = new string[2];
            AdSatırıAyrılmış[0] = AdSatırı[0];
            AdSatırıAyrılmış[1] = AdSatırı.Length > 1 ? AdSatırı[1].Replace(')', ' ').Trim() : "Diğer Adı Yok";
            return AdSatırıAyrılmış;
        }
        static EgeDeniziB BalıkClassOluştur(string balık)//verilen stringi balık classına dönüştüren method
        {
            string[] balıkSatırAyrılmış = balık.Split("\n\n");//balığın satırları ayrılıyor

            string AdSatırı = balıkSatırAyrılmış[0];//ilk ad satırı
            string[] AdSatırıAyrılmış = AdAyırma(AdSatırı);//diğer adı ayrılıyor
            string ad = AdSatırıAyrılmış[0];
            string bilgiPrg="";
            for (int i = 1; i < balıkSatırAyrılmış.Length; i++)//tüm satırları döndüğümüz for döngüsü
            {
                bilgiPrg += balıkSatırAyrılmış[i] + "\n\n";             
            }
            BinaryTree kelimeAğaç = bilgiKelimeAğacıOluştur(bilgiPrg);
            return new EgeDeniziB(ad, kelimeAğaç);
        }//balık class oluştur kapanışı
        static BinaryTree bilgiKelimeAğacıOluştur(string paragraf)
        {
            BinaryTree kelimeAğaç = new BinaryTree();
            HashSet<string> kelimeHash = new HashSet<string>();
            string[] satırSplit = paragraf.Split();

            foreach (string word in satırSplit) //ağaca ekleme döngüsü
            {
                string str = word;
                if (word.StartsWith('.') || word.StartsWith('(')) { str = word.Substring(1); }//başındaki sembolleri at
                if (word.EndsWith('.') || word.EndsWith(')') || word.EndsWith(',')) { str = word.Remove(word.Length - 1); }//sonundaki sembolleri at
                if (!str.Any(char.IsDigit))//kelimenin sayı olmadığı kontrol edildikten sonra hashSete ekleniyor
                {
                    str = str.ToLower();
                    kelimeHash.Add(str);
                }
            }
            
            foreach (string str in kelimeHash)
            {
                kelimeAğaç.Insert(str);
            }
            return kelimeAğaç;
        }
        static void OrtalamaDerinlikBulYazdır(BinaryTreeBalık BalıkAğacı)
        {
            int balıkSayısı = BalıkAğacı.balıkSayısı;
            double ortKelimeDerinlik = Math.Ceiling((double)BalıkAğacı.toplamKelimeDerinliği / balıkSayısı);
            double ortDengeli = Math.Ceiling((double)BalıkAğacı.toplamDengeliDerinlik / balıkSayısı);
            Console.WriteLine($"Ortalma Kelime Ağacı Derinliği : {BalıkAğacı.toplamKelimeDerinliği}/{BalıkAğacı.balıkSayısı} = {ortKelimeDerinlik} ," +
                              $"Dengeli olsaydı: {BalıkAğacı.toplamDengeliDerinlik}/{balıkSayısı} = {ortDengeli}");
        }
        static void DengeliAğacaEkleme(EgeDeniziB[] balıkArray, BinaryTreeBalık dengeliAğaç, int start, int end)
        {
            if (start <= end)
            {
                // ortayı bulma
                int mid = (start + end) / 2;
                dengeliAğaç.Insert(balıkArray[mid]);
                // Recursive olarak sol ve sağ için devam et
                DengeliAğacaEkleme(balıkArray, dengeliAğaç, start, mid - 1);
                DengeliAğacaEkleme(balıkArray, dengeliAğaç, mid + 1, end);
            }
        }
        static BinaryTreeBalık DengeliAğaçOluştur(BinaryTreeBalık balıkAğaç, EgeDeniziB[] balıkArray)
        {
            BinaryTreeBalık dengeliBalıkAğaç = new BinaryTreeBalık();

            DengeliAğacaEkleme(balıkArray, dengeliBalıkAğaç, 0, balıkArray.Length - 1);
            return dengeliBalıkAğaç;
        }

        static void HashTableEkle(Hashtable balıkHash, EgeDeniziB[] balıkArray)
        {
            int i = 0;
            foreach (EgeDeniziB b in balıkArray) 
            {
                Console.WriteLine(++i +" "+ b);
                if (b.BilgiKelimeAğacı != null)
                    balıkHash[b.BalıkAdı.Trim()] = b.BilgiKelimeAğacı;
                else balıkHash[b.BalıkAdı] = null;
            }
        }
        static void HashParagrafDeğiştir(Hashtable hash)
        {
            Console.WriteLine("Değiştirmek istediğiniz Balığın adı: ");
            string ad = Console.ReadLine();     // balığın adını konsoldan al
            if (ad == null || !hash.ContainsKey(ad)) 
            { 
                Console.WriteLine("Girdiğiniz Balık mevcut değil!");
                return; 
            }
            Console.WriteLine("YENİ paragrafı giriniz: ");
            string prg = Console.ReadLine();    // yeni paragrafı konsoldan al
            BinaryTree ağaç = bilgiKelimeAğacıOluştur(prg);  // metod kullanarak ağacı oluştur
            hash[ad] = ağaç;
        }

    }//program sonu


    public class EgeDeniziB
    {
        public string BalıkAdı;

        public BinaryTree BilgiKelimeAğacı;

        public EgeDeniziB()
        {
            BalıkAdı = "";
            BilgiKelimeAğacı = new BinaryTree();
        }
        public EgeDeniziB(string balıkAdı, BinaryTree bilgiKelimeAğacı)     //constructor
        {
            BalıkAdı = balıkAdı;
            BilgiKelimeAğacı = bilgiKelimeAğacı;
        }

        public override string ToString()
        {
            // Balık adını yazdırma
            return $"BALIK ADI: {this.BalıkAdı}\n";
        }
    }

    public class TreeNode
    {
        public string Word; // Düğümde saklanan kelime
        public TreeNode Left; // Sol alt düğüm
        public TreeNode Right; // Sağ alt düğüm

        public TreeNode(string word) // Düğüm oluştur
        {
            Word = word; 
            Left = null; 
            Right = null;
        }
    }

    public class BinaryTree
    {
        private TreeNode root; // Ağacın kök düğümü
        public string inOrderStr ="";
        public int düzey = -1, derinlik = 0, düğümSayısı=0;

        public TreeNode GetRoot()
        {
            return root;
        }
        
        public BinaryTree() // Boş Ağacı oluştur
        {
            root = null;
        }

        public void Insert(string word) // Kelime ekleme metodu
        {
            if (!this.Contains(this.root, word)) { düğümSayısı++; }//eğer kelime mevcut değilse düğüm sayısını 1 artır
            root = Insert(root, word); // Kök düğümden başlayarak ekleme işlemini başlat
        }

        private TreeNode Insert(TreeNode node, string word) // Recursive ekleme metodu
        {
            word = word.ToLower();
            if (node == null) // Eğer mevcut düğüm boşsa
            {
                return new TreeNode(word); // Yeni düğüm oluştur ve döndür
                
            }
            if (string.Compare(word, node.Word) < 0) // Eğer eklemek istediğimiz kelime mevcut düğümden küçükse
            {
                node.Left = Insert(node.Left, word); // Sol alt düğüme ekle
            }
            else if (string.Compare(word, node.Word) == 0)
            { 
                return null;
            }
            else // büyükse
            {
                node.Right = Insert(node.Right, word); // Sağ alt düğüme ekle
            }
            return node; // Mevcut düğümü döndür
        }

        public void PrintInOrder() // Kelimeleri alfabetik sırayla yazdırmak için metot
        {
            PrintInOrder(root); // Kök düğümden başlayarak yazdırma işlemini başlat
            Console.WriteLine(); // Yeni satır
        }
        private void PrintInOrder(TreeNode node) // InOrder alfabetik olarak yazdırma methodu
        {
            if (node != null) // Eğer mevcut düğüm boş değilse
            {
                PrintInOrder(node.Left); // Sol alt ağacı yazdır
                Console.Write(node.Word + " "); // Mevcut düğümü yazdır
                PrintInOrder(node.Right); // Sağ alt ağacı yazdır
            }
        }

        public void GetDepth(TreeNode node, int d) // derinlik bulma methodu
        {
            if (node != null)// node null değilse
            {
                d = d + 1; // derinliği 1 artır
                GetDepth(node.Left, d); // sol ağaç için recursive devam et
                // yaprağa ulaşıldığında daha derine ulaştıysa
                if ((node.Left == null) && (node.Right == null) && d > derinlik) 
                    derinlik = d; // derinliği güncelle
                GetDepth(node.Right, d);// sağ ağaç için tekrarla
            }
        }

        public bool Contains(TreeNode node, string kelime)
        {
            if (node == null)
                return false; // bulunamadı

            if (kelime.Equals(node.Word))
                return true; // bulundu

            else if (kelime.CompareTo(node.Word) < 0)
                return Contains(node.Left, kelime); // Search in the left subtree
            else
                return Contains(node.Right, kelime) ; // Search in the right subtree
        }

    }


    class TreeNodeBalık
    {
        public EgeDeniziB Balık; // Düğümde saklanan kelime
        public TreeNodeBalık Left; // Sol alt düğüm
        public TreeNodeBalık Right; // Sağ alt düğüm

        public TreeNodeBalık(EgeDeniziB balık) // Düğüm oluştur
        {
            Balık = balık;
            Left = null;
            Right = null;
        }
    }

    class BinaryTreeBalık
    {
        private TreeNodeBalık root; // Ağacın kök düğümü
        public int toplamKelimeDerinliği = 0;//, bAğaçDerinlik = 0;
        public double toplamDengeliDerinlik = 0;//, bAğaçDengeliDerinlik = 0;
        public int balıkSayısı = 0;// toplam Balık Sayısı
        public TreeNodeBalık getRoot()
        {
            return root;
        }
        public BinaryTreeBalık() // Boş Ağacı oluştur
        {
            root = null;
        }
        public void Insert(EgeDeniziB b) // Kelime ekleme metodu
        {
            if (b != null)
            {
                root = Insert(root, b); // Kök düğümden başlayarak ekleme işlemini başlat
                BinaryTree kAğacı = b.BilgiKelimeAğacı;
                kAğacı.GetDepth(kAğacı.GetRoot(), kAğacı.düzey);
                balıkSayısı++;
                toplamKelimeDerinliği += kAğacı.derinlik;
            }
        }
        private TreeNodeBalık Insert(TreeNodeBalık node, EgeDeniziB b) // Recursive ekleme metodu
        {
            if (node == null) // Eğer mevcut düğüm boşsa
            {
                return new TreeNodeBalık(b); // Yeni düğüm oluştur ve döndür
            }
            if (string.Compare(b.BalıkAdı, node.Balık.BalıkAdı) < 0) // Eğer eklemek istediğimiz kelime mevcut düğümden küçükse
            {
                node.Left = Insert(node.Left, b); // Sol alt düğüme ekle
            }
            else // büyükse
            {
                node.Right = Insert(node.Right, b); // Sağ alt düğüme ekle
            }
            return node; // Mevcut düğümü döndür
        }
        public void PrintInOrder() // Kelimeleri alfabetik sırayla yazdırmak için metot
        {
            PrintInOrder(root); // Kök düğümden başlayarak yazdırma işlemini başlat
            Console.WriteLine(); // Yeni satır
        }
        public void PrintInOrder(TreeNodeBalık node) // InOrder alfabetik olarak yazdırma methodu
        {
            if (node != null) // Eğer mevcut düğüm boş değilse
            {
                EgeDeniziB b = node.Balık;
                BinaryTree kAğaç = b.BilgiKelimeAğacı;

                PrintInOrder(node.Left); // Sol alt ağacı yazdır

                Console.WriteLine(b + "KELİME AĞACI : ");
                kAğaç.PrintInOrder();// Mevcut düğümü yazdır

                double dengeliDerinlik = Math.Floor(Math.Log2(kAğaç.düğümSayısı+1)-1);
                toplamDengeliDerinlik += dengeliDerinlik;
                kAğaç.GetDepth(kAğaç.GetRoot(), -1);
                Console.WriteLine($"Kelime Ağacı Derinliği: {kAğaç.derinlik} , Düğüm Sayısı: {kAğaç.düğümSayısı} , Dengeli olsaydı derinliği: {dengeliDerinlik} ");
                Console.WriteLine();

                PrintInOrder(node.Right); // Sağ alt ağacı yazdır
            }
        }

        public EgeDeniziB[] ToArray()
        {
            EgeDeniziB[] arr = new EgeDeniziB[balıkSayısı]; // Balık sayısına uygun dizi oluştur
            int index = 0; // Dizinin hangi pozisyonunun doldurulduğunu takip eden değişken
            InorderArrayeEkle(root, arr, ref index); // Diziye doldurma işlemini başlat
            return arr; // Doldurulmuş diziyi döndür
        }

        private void InorderArrayeEkle(TreeNodeBalık node, EgeDeniziB[] array, ref int index)
        {
            if (node == null) // Eğer düğüm boşsa işlemi sonlandır
                return;

            InorderArrayeEkle(node.Left, array, ref index); // Sol alt ağacı diziye ekle
            array[index++] = node.Balık; // Mevcut düğümdeki veriyi diziye ekle ve index'i artır
            InorderArrayeEkle(node.Right, array, ref index); // Sağ alt ağacı diziye ekle
        }
        public void PrintPostOrder(TreeNodeBalık node)
        {
            if (node != null) // Eğer mevcut düğüm boş değilse
            {
                EgeDeniziB b = node.Balık;
                BinaryTree kAğaç = b.BilgiKelimeAğacı;

                Console.WriteLine(b.BalıkAdı);
                PrintPostOrder(node.Left); // Sol alt ağacı yazdır
                PrintPostOrder(node.Right); // Sağ alt ağacı yazdır
            }
        }

        public void ArasınıYazdır(char start, char end)
        {   
            start = char.ToLower(start);
            end = char.ToLower(end);
            Console.WriteLine($"{start}, {end} harfleri arasındaki balık adları :  ");
            ArasınıYazdırRec(root, start, end);
        }

        private void ArasınıYazdırRec(TreeNodeBalık node, char start, char end)
        {
            if (node == null)
                return;

            string balıkAd = node.Balık.BalıkAdı;
            char balıkBaşharf = char.ToLower(balıkAd[1]);// adın başında 1 boşluk olduğu için
            //Console.WriteLine($"Balık adı: {balıkAd}, Baş harf: {balıkBaşharf}");

            // Sol alt ağacı kontrol et
            ArasınıYazdırRec(node.Left, start, end);

            // Mevcut düğümü kontrol et
            if (balıkBaşharf >= start && balıkBaşharf <= end)
            {
                Console.Write(balıkAd + ", ");
            }

            // Sağ alt ağacı kontrol et
            ArasınıYazdırRec(node.Right, start, end);
        }
    }
    public class MaxHeap
    {
        private EgeDeniziB[] heapArr; // heap elemanları tutan array
        private int currSize;  // array anlık boyutu
        private int capacity; // heap max boyutu

        public MaxHeap(int capacity)
        {
            this.capacity = capacity;
            this.heapArr = new EgeDeniziB[capacity];
            this.currSize = 0;
        }

        // heap eleman ekleme
        public void Ekle(EgeDeniziB balık)
        {
            if (currSize == capacity)
            {
                throw new InvalidOperationException("Heap is full.");
            }

            heapArr[currSize] = balık; // Place the value at the end of the array
            HeapifyUp(currSize);    // Fix the heap property
            currSize++;
        }

        // Rootu sil ve döndür (en büyük eleman) 
        public EgeDeniziB Sil()
        {
            if (currSize == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            EgeDeniziB root = heapArr[0];
            heapArr[0] = heapArr[currSize-1]; // son elemanla rootu değiştir
            currSize--;                   // eleman sayısını düşür
            HeapifyDown(0);           // heap aşağı doğru düzenle
            return root;
        }

        // Root elemanına ulaşma
        public EgeDeniziB Peek()
        {
            if (currSize == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return heapArr[0];
        }

        // heap yukarı doğru düzenleme methodu (eleman ekleme) 
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                string childName = heapArr[index].BalıkAdı;
                string parentName = heapArr[parentIndex].BalıkAdı;
                if (childName.CompareTo(parentName) == 1) // child parent'ından küçük ise döngğden çık
                    break;
                // parent ile child yer değiştir
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        // aşağı dopru heap düzenle (eleman çıkarma)
        private void HeapifyDown(int index)
        {
            while (true)
            {
                int leftChild = 2 * index + 1;//sol çocuk
                int rightChild = leftChild + 1 ;//sağ çocuk
                int largest = index;
                string leftName = heapArr[leftChild].BalıkAdı;
                string rightName = heapArr[rightChild].BalıkAdı;
                string largestName = heapArr[largest].BalıkAdı;

                if (leftChild < currSize && leftName.CompareTo(largestName) == 1) // leftChild mevcut ve parenttan büyük ise
                {
                    largest = leftChild;
                }

                if (rightChild < currSize && rightName.CompareTo(largestName) == 1) // rightChild mevcut ve parenttan büyük ise
                {
                    largest = rightChild;
                }

                if (largest == index)
                    break;

                Swap(index, largest); // en büyük çocuk ile yer değiştir
                
                index = largest; // indexi çocuğa eşitle ardından döngü tekrar dönsün
            }
        }

        // array eleman yer değiştirme
        private void Swap(int i, int j)
        {
            EgeDeniziB temp = heapArr[i];
            heapArr[i] = heapArr[j];
            heapArr[j] = temp;
        }

        // Heap tamamını yazdırma
        public void Yazdır()
        {
            for (int i = 0; i < currSize; i++)
            {
                Console.Write(heapArr[i].BalıkAdı + " ");
            }
            Console.WriteLine();
        }
    }
}
