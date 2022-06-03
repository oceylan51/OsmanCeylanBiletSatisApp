using CeylanTurizm.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed()
        {
            var context = new CeylanTurizmDbContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Buses.Count() == 0)
                {
                    context.Buses.AddRange(buses);
                }
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(cities);
                }
                if (context.Expeditions.Count() == 0)
                {
                    context.Expeditions.AddRange(expeditions);
                }
                if (context.TicketSales.Count() == 0)
                {
                    context.TicketSales.AddRange(ticketSales);
                }
                context.SaveChanges();
            }
        }
        private static Bus[] buses =
        {
            new Bus()
            {
                BusPlaque="51 AC 41",
                BusDriver="Habib Ceylan",
                BusSeatingCapacity=45
            },
            new Bus()
            {
                BusPlaque="51 GS 1905",
                BusDriver="Burak Korkmaz",
                BusSeatingCapacity=45
            },
            new Bus()
            {
                BusPlaque="06 AT 214",
                BusDriver="Ahmet Öztürk",
                BusSeatingCapacity=45
            },
            new Bus()
            {
                BusPlaque="23 AV 264",
                BusDriver="Osman Ceylan",
                BusSeatingCapacity=45
            },
            new Bus()
            {
                BusPlaque="37 AS 325",
                BusDriver="Mehmet Sahin",
                BusSeatingCapacity=45
            }
        };
        private static City[] cities =
        {
            new City()
            {
                CityNo=51,
                CityName="Niğde",
                CityImg="Daha Sonra Düzeltilecek",
                CityTitle = "Birçok uygarlığa tanık olmuş Çanakkale’nin asıl tarihi Truva ile başlar." +
                " Bu önemli topraklar üzerine Aiokialıların, Lidyalıların, Perslerin, Anadolu Beyliklerinin, " +
                "Osmanlıların ve başka birçok medeniyetin izleri vardır.",
                CityDescription="ve başka birçok medeniyetin izleri vardır.Geçmişten günümüze taşıdığı köklü tarihi ile Çanakkale; " +
                "Biga ve Gelibolu yarımadaları üzerinde kurulu bir açık hava müzesi. " +
                "Tarihi yaşamışlıkları, arkeolojik eserleri, doğal güzellikleri ile ülkemizin en ilgi çekici şehirlerinden biri. " +
                "Gökçeada, Bozcaada, Assos gibi turizm merkezleri de olan Çanakkale siz gezginlerin buluşması noktası olacak." +
                "Ülkemizin dönüm noktalarından birinin yaşandığı yer, Gelibolu Yarımadası Tarihi Milli Parkı… Kilitbahir Kalesi, " +
                "Seyit Onbaşı Anıtı ve Mecidiye Tabyaları, Çanakkale Şehitler Abidesi, 57. Alay Şehitliği, Conkbayırı, Atatürk Anıtı ve Siperler. " +
                "Fedakarlıklar ve kahramanlıkların yaşandığı, vatan uğruna şehit olan gurur kaynaklarımızı anmadan dönmek olmaz Çanakkale’den.",
                CityDescription2="• Çanakkale Saat Kulesi, Çanakkale Arkeoloji Müzesi, Çanakkale Deniz Müzesi’nde Nusret Mayın Gemisi görmenizi tavsiye ettiğimiz diğer yerlerden.• Ezine ilçesindeki dünyanın en önemli antik kentlerinden Truva Antik Kenti, Truva Savaşları’nın meydana geldiği yer olarak bilinir ve Çanakkale’de mutlaka görmenizi öneririz.• Seyahatnamelere, türkülere konu olan Aynalı Çarşı Çanakkale’nin simgelerinden biri. Mısır Çarşısı’nın bir küçüğü olarak nitelendirilen Aynalı Çarşı’yı gitmişken görün isterseniz.• Assos Antik Kenti, Antik Liman, Behramkale Köyü ve Athena Tapınağı ile mutlaka görmeniz gereken yerler arasında olan Assos’ta huzuru yakalayacaksınız.• Bozcaada ve Gökçeada’da ise sokaklarda dolaşırken kültürlerin izine her noktada rastlayacaksınız.",
                CityDescription3="• Boğazın bir ucundan diğer ucuna görebileceğiniz İntepe’de ufkunuz açılacak.• Alpler’den sonra dünyanın en fazla oksijen üreten yeri olan Kaz Dağları; Şahindere Kanyonu, Ayazma, Sütüven Göletleri gibi doğal güzellikleri, taş evleri olan köyleri, orman gözetleme kulelerinin yer aldığı manzara noktaları, şifalı suları ile Türkiye’nin görülmesi gereken en değerleri yerlerinden biri. Yolunuz düşerse uğramadan geçmeyin.• Kordon boyunca güzel bir yürüyüş yapabilir, boğazın havasını içine çekip, Gelibolu manzarasına karşı keyifle oturabilirsiniz.• Çanakkale dalış için seçilecek en iyi yerlerden biri. Savaş zamanından kalan batık gemiler ve onları saran deniz canlıları ile farklı bir deneyim yaşayabilirsiniz.• Kazdağları’nın en güzel köyleri Yeşilyurt ve Adatepe‘ye uğramanızı tavsiye ederiz. Özellikle Adatepe’deki Zeus Altarı ve Zeytinyağı Müzesi’ni mutlaka görmelisiniz. Yeşilyurt Köyü’ndeki butik taş otellerde konaklayabilirsiniz.",
                CityDescription4="• Saygın bir çağdaş sanat etkinliği olan Uluslararası Çanakkale Bienali değerli ve önemli ulusal ve uluslararası sanatçıların, sanat ve kültür kurumlarının, sanat eleştirmenleri ve küratörlerin katılım ve iş birlikleriyle hayata geçirilen sanatseverlerin buluştuğu bir etkinlik.• Eskiden hamam olarak kullanılan Seramik Müzesi, Geleneksel Çanakkale Seramikleri’nin geçmişten günümüze olan süreçte gelişimini anlatıyor. Ayrıca müzede atölye ve sergi gibi çeşitli etkinlikler yapılıyor. İsterseniz siz de burada seramik yapma deneyimini yaşayabilirsiniz.• UNESCO tarafından dünya mirası olarak gösterilen Troia Antik Kenti’nden adını alan Uluslararası Troia Festivali; tarih, kültür, sanat, barış ve gelecek gibi konuları ele alan kültürel ve sanatsal etkinlikleri artırmak ve bu birleştirici gücü insanlara yansıtmak amacıyla yapılan keyifli bir festival. Gidiş tarihleriniz ile festival tarihi uyarsa mutlaka katılmanızı öneriyoruz.",
                CityDescription5="• Çanakkale denince akla ilk gelen lezzetler Ezine peyniri, domates ve peynir helvası, ama yöresel yemeklerine bir daldık mı; ovmaç, iskorpit, ıspanak çorbası; tumbi, ıspanak sarması, çırpma, melki yemeği, yumurtalı tiken, metez, tarhanalı patlıcan, börülce köftesi, lüfer pilavı, deli armut turşusu (ahlat turşusu), kaymaklı lorlu biber böreği, kabaklı Saroz böreği ve Gelibolu böreği, piruhi, hıdrellez yahnisi, tavuklu mantı, bakla keşkeği, deve sucuğu ve bitmeyen lezzetleri…• Deniz memleketi olan Çanakkale sardalyesi ile de meşhur. Sardalye balığından yapılan binbir türlü yemeği tatmanızı öneririz.• Kordon’da midye dolmasının en lezzetlisini yiyebilirsiniz.• Bozcaada’da taze deniz ürünleri, adaya özgü otlardan yapılan mezeler ile enfes yemekler yiyebilirsiniz. Bağ bozumuna denk gelirseniz Bozcaada’nın üzümlerini tatmanızı öneririz. Adadan dönerken içi bademli domates reçeli, üzüm reçeli, gelincik reçeli, koruk suyu ve sakızlı bademli kurabiye almadan dönmeyin bizce.• Şehir Müzesi’nin yakınındaki Yalı Hanı içerisinde yer alan kafelerde tatlınızı alıp çayınızın tadını çıkarmanızı tavsiye ederiz."
            },
            new City()
            {
                CityNo=34,
                CityName="Istanbul",
                CityImg="Daha Sonra Düzeltilecek",
                CityTitle = "Birçok uygarlığa tanık olmuş Çanakkale’nin asıl tarihi Truva ile başlar." +
                " Bu önemli topraklar üzerine Aiokialıların, Lidyalıların, Perslerin, Anadolu Beyliklerinin, " +
                "Osmanlıların ve başka birçok medeniyetin izleri vardır.",
                CityDescription="ve başka birçok medeniyetin izleri vardır.Geçmişten günümüze taşıdığı köklü tarihi ile Çanakkale; " +
                "Biga ve Gelibolu yarımadaları üzerinde kurulu bir açık hava müzesi. " +
                "Tarihi yaşamışlıkları, arkeolojik eserleri, doğal güzellikleri ile ülkemizin en ilgi çekici şehirlerinden biri. " +
                "Gökçeada, Bozcaada, Assos gibi turizm merkezleri de olan Çanakkale siz gezginlerin buluşması noktası olacak." +
                "Ülkemizin dönüm noktalarından birinin yaşandığı yer, Gelibolu Yarımadası Tarihi Milli Parkı… Kilitbahir Kalesi, " +
                "Seyit Onbaşı Anıtı ve Mecidiye Tabyaları, Çanakkale Şehitler Abidesi, 57. Alay Şehitliği, Conkbayırı, Atatürk Anıtı ve Siperler. " +
                "Fedakarlıklar ve kahramanlıkların yaşandığı, vatan uğruna şehit olan gurur kaynaklarımızı anmadan dönmek olmaz Çanakkale’den.",
                CityDescription2="• Çanakkale Saat Kulesi, Çanakkale Arkeoloji Müzesi, Çanakkale Deniz Müzesi’nde Nusret Mayın Gemisi görmenizi tavsiye ettiğimiz diğer yerlerden.• Ezine ilçesindeki dünyanın en önemli antik kentlerinden Truva Antik Kenti, Truva Savaşları’nın meydana geldiği yer olarak bilinir ve Çanakkale’de mutlaka görmenizi öneririz.• Seyahatnamelere, türkülere konu olan Aynalı Çarşı Çanakkale’nin simgelerinden biri. Mısır Çarşısı’nın bir küçüğü olarak nitelendirilen Aynalı Çarşı’yı gitmişken görün isterseniz.• Assos Antik Kenti, Antik Liman, Behramkale Köyü ve Athena Tapınağı ile mutlaka görmeniz gereken yerler arasında olan Assos’ta huzuru yakalayacaksınız.• Bozcaada ve Gökçeada’da ise sokaklarda dolaşırken kültürlerin izine her noktada rastlayacaksınız.",
                CityDescription3="• Boğazın bir ucundan diğer ucuna görebileceğiniz İntepe’de ufkunuz açılacak.• Alpler’den sonra dünyanın en fazla oksijen üreten yeri olan Kaz Dağları; Şahindere Kanyonu, Ayazma, Sütüven Göletleri gibi doğal güzellikleri, taş evleri olan köyleri, orman gözetleme kulelerinin yer aldığı manzara noktaları, şifalı suları ile Türkiye’nin görülmesi gereken en değerleri yerlerinden biri. Yolunuz düşerse uğramadan geçmeyin.• Kordon boyunca güzel bir yürüyüş yapabilir, boğazın havasını içine çekip, Gelibolu manzarasına karşı keyifle oturabilirsiniz.• Çanakkale dalış için seçilecek en iyi yerlerden biri. Savaş zamanından kalan batık gemiler ve onları saran deniz canlıları ile farklı bir deneyim yaşayabilirsiniz.• Kazdağları’nın en güzel köyleri Yeşilyurt ve Adatepe‘ye uğramanızı tavsiye ederiz. Özellikle Adatepe’deki Zeus Altarı ve Zeytinyağı Müzesi’ni mutlaka görmelisiniz. Yeşilyurt Köyü’ndeki butik taş otellerde konaklayabilirsiniz.",
                CityDescription4="• Saygın bir çağdaş sanat etkinliği olan Uluslararası Çanakkale Bienali değerli ve önemli ulusal ve uluslararası sanatçıların, sanat ve kültür kurumlarının, sanat eleştirmenleri ve küratörlerin katılım ve iş birlikleriyle hayata geçirilen sanatseverlerin buluştuğu bir etkinlik.• Eskiden hamam olarak kullanılan Seramik Müzesi, Geleneksel Çanakkale Seramikleri’nin geçmişten günümüze olan süreçte gelişimini anlatıyor. Ayrıca müzede atölye ve sergi gibi çeşitli etkinlikler yapılıyor. İsterseniz siz de burada seramik yapma deneyimini yaşayabilirsiniz.• UNESCO tarafından dünya mirası olarak gösterilen Troia Antik Kenti’nden adını alan Uluslararası Troia Festivali; tarih, kültür, sanat, barış ve gelecek gibi konuları ele alan kültürel ve sanatsal etkinlikleri artırmak ve bu birleştirici gücü insanlara yansıtmak amacıyla yapılan keyifli bir festival. Gidiş tarihleriniz ile festival tarihi uyarsa mutlaka katılmanızı öneriyoruz.",
                CityDescription5="• Çanakkale denince akla ilk gelen lezzetler Ezine peyniri, domates ve peynir helvası, ama yöresel yemeklerine bir daldık mı; ovmaç, iskorpit, ıspanak çorbası; tumbi, ıspanak sarması, çırpma, melki yemeği, yumurtalı tiken, metez, tarhanalı patlıcan, börülce köftesi, lüfer pilavı, deli armut turşusu (ahlat turşusu), kaymaklı lorlu biber böreği, kabaklı Saroz böreği ve Gelibolu böreği, piruhi, hıdrellez yahnisi, tavuklu mantı, bakla keşkeği, deve sucuğu ve bitmeyen lezzetleri…• Deniz memleketi olan Çanakkale sardalyesi ile de meşhur. Sardalye balığından yapılan binbir türlü yemeği tatmanızı öneririz.• Kordon’da midye dolmasının en lezzetlisini yiyebilirsiniz.• Bozcaada’da taze deniz ürünleri, adaya özgü otlardan yapılan mezeler ile enfes yemekler yiyebilirsiniz. Bağ bozumuna denk gelirseniz Bozcaada’nın üzümlerini tatmanızı öneririz. Adadan dönerken içi bademli domates reçeli, üzüm reçeli, gelincik reçeli, koruk suyu ve sakızlı bademli kurabiye almadan dönmeyin bizce.• Şehir Müzesi’nin yakınındaki Yalı Hanı içerisinde yer alan kafelerde tatlınızı alıp çayınızın tadını çıkarmanızı tavsiye ederiz."
            },
            new City()
            {
                CityNo=3,
                CityName="Afyon",
                CityImg="Daha Sonra Düzeltilecek",
                CityTitle = "Birçok uygarlığa tanık olmuş Çanakkale’nin asıl tarihi Truva ile başlar." +
                " Bu önemli topraklar üzerine Aiokialıların, Lidyalıların, Perslerin, Anadolu Beyliklerinin, " +
                "Osmanlıların ve başka birçok medeniyetin izleri vardır.",
                CityDescription="ve başka birçok medeniyetin izleri vardır.Geçmişten günümüze taşıdığı köklü tarihi ile Çanakkale; " +
                "Biga ve Gelibolu yarımadaları üzerinde kurulu bir açık hava müzesi. " +
                "Tarihi yaşamışlıkları, arkeolojik eserleri, doğal güzellikleri ile ülkemizin en ilgi çekici şehirlerinden biri. " +
                "Gökçeada, Bozcaada, Assos gibi turizm merkezleri de olan Çanakkale siz gezginlerin buluşması noktası olacak." +
                "Ülkemizin dönüm noktalarından birinin yaşandığı yer, Gelibolu Yarımadası Tarihi Milli Parkı… Kilitbahir Kalesi, " +
                "Seyit Onbaşı Anıtı ve Mecidiye Tabyaları, Çanakkale Şehitler Abidesi, 57. Alay Şehitliği, Conkbayırı, Atatürk Anıtı ve Siperler. " +
                "Fedakarlıklar ve kahramanlıkların yaşandığı, vatan uğruna şehit olan gurur kaynaklarımızı anmadan dönmek olmaz Çanakkale’den.",
                CityDescription2="• Çanakkale Saat Kulesi, Çanakkale Arkeoloji Müzesi, Çanakkale Deniz Müzesi’nde Nusret Mayın Gemisi görmenizi tavsiye ettiğimiz diğer yerlerden.• Ezine ilçesindeki dünyanın en önemli antik kentlerinden Truva Antik Kenti, Truva Savaşları’nın meydana geldiği yer olarak bilinir ve Çanakkale’de mutlaka görmenizi öneririz.• Seyahatnamelere, türkülere konu olan Aynalı Çarşı Çanakkale’nin simgelerinden biri. Mısır Çarşısı’nın bir küçüğü olarak nitelendirilen Aynalı Çarşı’yı gitmişken görün isterseniz.• Assos Antik Kenti, Antik Liman, Behramkale Köyü ve Athena Tapınağı ile mutlaka görmeniz gereken yerler arasında olan Assos’ta huzuru yakalayacaksınız.• Bozcaada ve Gökçeada’da ise sokaklarda dolaşırken kültürlerin izine her noktada rastlayacaksınız.",
                CityDescription3="• Boğazın bir ucundan diğer ucuna görebileceğiniz İntepe’de ufkunuz açılacak.• Alpler’den sonra dünyanın en fazla oksijen üreten yeri olan Kaz Dağları; Şahindere Kanyonu, Ayazma, Sütüven Göletleri gibi doğal güzellikleri, taş evleri olan köyleri, orman gözetleme kulelerinin yer aldığı manzara noktaları, şifalı suları ile Türkiye’nin görülmesi gereken en değerleri yerlerinden biri. Yolunuz düşerse uğramadan geçmeyin.• Kordon boyunca güzel bir yürüyüş yapabilir, boğazın havasını içine çekip, Gelibolu manzarasına karşı keyifle oturabilirsiniz.• Çanakkale dalış için seçilecek en iyi yerlerden biri. Savaş zamanından kalan batık gemiler ve onları saran deniz canlıları ile farklı bir deneyim yaşayabilirsiniz.• Kazdağları’nın en güzel köyleri Yeşilyurt ve Adatepe‘ye uğramanızı tavsiye ederiz. Özellikle Adatepe’deki Zeus Altarı ve Zeytinyağı Müzesi’ni mutlaka görmelisiniz. Yeşilyurt Köyü’ndeki butik taş otellerde konaklayabilirsiniz.",
                CityDescription4="• Saygın bir çağdaş sanat etkinliği olan Uluslararası Çanakkale Bienali değerli ve önemli ulusal ve uluslararası sanatçıların, sanat ve kültür kurumlarının, sanat eleştirmenleri ve küratörlerin katılım ve iş birlikleriyle hayata geçirilen sanatseverlerin buluştuğu bir etkinlik.• Eskiden hamam olarak kullanılan Seramik Müzesi, Geleneksel Çanakkale Seramikleri’nin geçmişten günümüze olan süreçte gelişimini anlatıyor. Ayrıca müzede atölye ve sergi gibi çeşitli etkinlikler yapılıyor. İsterseniz siz de burada seramik yapma deneyimini yaşayabilirsiniz.• UNESCO tarafından dünya mirası olarak gösterilen Troia Antik Kenti’nden adını alan Uluslararası Troia Festivali; tarih, kültür, sanat, barış ve gelecek gibi konuları ele alan kültürel ve sanatsal etkinlikleri artırmak ve bu birleştirici gücü insanlara yansıtmak amacıyla yapılan keyifli bir festival. Gidiş tarihleriniz ile festival tarihi uyarsa mutlaka katılmanızı öneriyoruz.",
                CityDescription5="• Çanakkale denince akla ilk gelen lezzetler Ezine peyniri, domates ve peynir helvası, ama yöresel yemeklerine bir daldık mı; ovmaç, iskorpit, ıspanak çorbası; tumbi, ıspanak sarması, çırpma, melki yemeği, yumurtalı tiken, metez, tarhanalı patlıcan, börülce köftesi, lüfer pilavı, deli armut turşusu (ahlat turşusu), kaymaklı lorlu biber böreği, kabaklı Saroz böreği ve Gelibolu böreği, piruhi, hıdrellez yahnisi, tavuklu mantı, bakla keşkeği, deve sucuğu ve bitmeyen lezzetleri…• Deniz memleketi olan Çanakkale sardalyesi ile de meşhur. Sardalye balığından yapılan binbir türlü yemeği tatmanızı öneririz.• Kordon’da midye dolmasının en lezzetlisini yiyebilirsiniz.• Bozcaada’da taze deniz ürünleri, adaya özgü otlardan yapılan mezeler ile enfes yemekler yiyebilirsiniz. Bağ bozumuna denk gelirseniz Bozcaada’nın üzümlerini tatmanızı öneririz. Adadan dönerken içi bademli domates reçeli, üzüm reçeli, gelincik reçeli, koruk suyu ve sakızlı bademli kurabiye almadan dönmeyin bizce.• Şehir Müzesi’nin yakınındaki Yalı Hanı içerisinde yer alan kafelerde tatlınızı alıp çayınızın tadını çıkarmanızı tavsiye ederiz."
            },
            new City()
            {
                CityNo=6,
                CityName="Ankara",
                CityImg="Daha Sonra Düzeltilecek",
                CityTitle = "Birçok uygarlığa tanık olmuş Çanakkale’nin asıl tarihi Truva ile başlar." +
                " Bu önemli topraklar üzerine Aiokialıların, Lidyalıların, Perslerin, Anadolu Beyliklerinin, " +
                "Osmanlıların ve başka birçok medeniyetin izleri vardır.",
                CityDescription="ve başka birçok medeniyetin izleri vardır.Geçmişten günümüze taşıdığı köklü tarihi ile Çanakkale; " +
                "Biga ve Gelibolu yarımadaları üzerinde kurulu bir açık hava müzesi. " +
                "Tarihi yaşamışlıkları, arkeolojik eserleri, doğal güzellikleri ile ülkemizin en ilgi çekici şehirlerinden biri. " +
                "Gökçeada, Bozcaada, Assos gibi turizm merkezleri de olan Çanakkale siz gezginlerin buluşması noktası olacak." +
                "Ülkemizin dönüm noktalarından birinin yaşandığı yer, Gelibolu Yarımadası Tarihi Milli Parkı… Kilitbahir Kalesi, " +
                "Seyit Onbaşı Anıtı ve Mecidiye Tabyaları, Çanakkale Şehitler Abidesi, 57. Alay Şehitliği, Conkbayırı, Atatürk Anıtı ve Siperler. " +
                "Fedakarlıklar ve kahramanlıkların yaşandığı, vatan uğruna şehit olan gurur kaynaklarımızı anmadan dönmek olmaz Çanakkale’den.",
                CityDescription2="• Çanakkale Saat Kulesi, Çanakkale Arkeoloji Müzesi, Çanakkale Deniz Müzesi’nde Nusret Mayın Gemisi görmenizi tavsiye ettiğimiz diğer yerlerden.• Ezine ilçesindeki dünyanın en önemli antik kentlerinden Truva Antik Kenti, Truva Savaşları’nın meydana geldiği yer olarak bilinir ve Çanakkale’de mutlaka görmenizi öneririz.• Seyahatnamelere, türkülere konu olan Aynalı Çarşı Çanakkale’nin simgelerinden biri. Mısır Çarşısı’nın bir küçüğü olarak nitelendirilen Aynalı Çarşı’yı gitmişken görün isterseniz.• Assos Antik Kenti, Antik Liman, Behramkale Köyü ve Athena Tapınağı ile mutlaka görmeniz gereken yerler arasında olan Assos’ta huzuru yakalayacaksınız.• Bozcaada ve Gökçeada’da ise sokaklarda dolaşırken kültürlerin izine her noktada rastlayacaksınız.",
                CityDescription3="• Boğazın bir ucundan diğer ucuna görebileceğiniz İntepe’de ufkunuz açılacak.• Alpler’den sonra dünyanın en fazla oksijen üreten yeri olan Kaz Dağları; Şahindere Kanyonu, Ayazma, Sütüven Göletleri gibi doğal güzellikleri, taş evleri olan köyleri, orman gözetleme kulelerinin yer aldığı manzara noktaları, şifalı suları ile Türkiye’nin görülmesi gereken en değerleri yerlerinden biri. Yolunuz düşerse uğramadan geçmeyin.• Kordon boyunca güzel bir yürüyüş yapabilir, boğazın havasını içine çekip, Gelibolu manzarasına karşı keyifle oturabilirsiniz.• Çanakkale dalış için seçilecek en iyi yerlerden biri. Savaş zamanından kalan batık gemiler ve onları saran deniz canlıları ile farklı bir deneyim yaşayabilirsiniz.• Kazdağları’nın en güzel köyleri Yeşilyurt ve Adatepe‘ye uğramanızı tavsiye ederiz. Özellikle Adatepe’deki Zeus Altarı ve Zeytinyağı Müzesi’ni mutlaka görmelisiniz. Yeşilyurt Köyü’ndeki butik taş otellerde konaklayabilirsiniz.",
                CityDescription4="• Saygın bir çağdaş sanat etkinliği olan Uluslararası Çanakkale Bienali değerli ve önemli ulusal ve uluslararası sanatçıların, sanat ve kültür kurumlarının, sanat eleştirmenleri ve küratörlerin katılım ve iş birlikleriyle hayata geçirilen sanatseverlerin buluştuğu bir etkinlik.• Eskiden hamam olarak kullanılan Seramik Müzesi, Geleneksel Çanakkale Seramikleri’nin geçmişten günümüze olan süreçte gelişimini anlatıyor. Ayrıca müzede atölye ve sergi gibi çeşitli etkinlikler yapılıyor. İsterseniz siz de burada seramik yapma deneyimini yaşayabilirsiniz.• UNESCO tarafından dünya mirası olarak gösterilen Troia Antik Kenti’nden adını alan Uluslararası Troia Festivali; tarih, kültür, sanat, barış ve gelecek gibi konuları ele alan kültürel ve sanatsal etkinlikleri artırmak ve bu birleştirici gücü insanlara yansıtmak amacıyla yapılan keyifli bir festival. Gidiş tarihleriniz ile festival tarihi uyarsa mutlaka katılmanızı öneriyoruz.",
                CityDescription5="• Çanakkale denince akla ilk gelen lezzetler Ezine peyniri, domates ve peynir helvası, ama yöresel yemeklerine bir daldık mı; ovmaç, iskorpit, ıspanak çorbası; tumbi, ıspanak sarması, çırpma, melki yemeği, yumurtalı tiken, metez, tarhanalı patlıcan, börülce köftesi, lüfer pilavı, deli armut turşusu (ahlat turşusu), kaymaklı lorlu biber böreği, kabaklı Saroz böreği ve Gelibolu böreği, piruhi, hıdrellez yahnisi, tavuklu mantı, bakla keşkeği, deve sucuğu ve bitmeyen lezzetleri…• Deniz memleketi olan Çanakkale sardalyesi ile de meşhur. Sardalye balığından yapılan binbir türlü yemeği tatmanızı öneririz.• Kordon’da midye dolmasının en lezzetlisini yiyebilirsiniz.• Bozcaada’da taze deniz ürünleri, adaya özgü otlardan yapılan mezeler ile enfes yemekler yiyebilirsiniz. Bağ bozumuna denk gelirseniz Bozcaada’nın üzümlerini tatmanızı öneririz. Adadan dönerken içi bademli domates reçeli, üzüm reçeli, gelincik reçeli, koruk suyu ve sakızlı bademli kurabiye almadan dönmeyin bizce.• Şehir Müzesi’nin yakınındaki Yalı Hanı içerisinde yer alan kafelerde tatlınızı alıp çayınızın tadını çıkarmanızı tavsiye ederiz."
            },
            new City()
            {
                CityNo=16,
                CityName="Bursa",
                CityImg="Daha Sonra Düzeltilecek",
                CityTitle = "Birçok uygarlığa tanık olmuş Çanakkale’nin asıl tarihi Truva ile başlar." +
                " Bu önemli topraklar üzerine Aiokialıların, Lidyalıların, Perslerin, Anadolu Beyliklerinin, " +
                "Osmanlıların ve başka birçok medeniyetin izleri vardır.",
                CityDescription="ve başka birçok medeniyetin izleri vardır.Geçmişten günümüze taşıdığı köklü tarihi ile Çanakkale; " +
                "Biga ve Gelibolu yarımadaları üzerinde kurulu bir açık hava müzesi. " +
                "Tarihi yaşamışlıkları, arkeolojik eserleri, doğal güzellikleri ile ülkemizin en ilgi çekici şehirlerinden biri. " +
                "Gökçeada, Bozcaada, Assos gibi turizm merkezleri de olan Çanakkale siz gezginlerin buluşması noktası olacak." +
                "Ülkemizin dönüm noktalarından birinin yaşandığı yer, Gelibolu Yarımadası Tarihi Milli Parkı… Kilitbahir Kalesi, " +
                "Seyit Onbaşı Anıtı ve Mecidiye Tabyaları, Çanakkale Şehitler Abidesi, 57. Alay Şehitliği, Conkbayırı, Atatürk Anıtı ve Siperler. " +
                "Fedakarlıklar ve kahramanlıkların yaşandığı, vatan uğruna şehit olan gurur kaynaklarımızı anmadan dönmek olmaz Çanakkale’den.",
                CityDescription2="• Çanakkale Saat Kulesi, Çanakkale Arkeoloji Müzesi, Çanakkale Deniz Müzesi’nde Nusret Mayın Gemisi görmenizi tavsiye ettiğimiz diğer yerlerden.• Ezine ilçesindeki dünyanın en önemli antik kentlerinden Truva Antik Kenti, Truva Savaşları’nın meydana geldiği yer olarak bilinir ve Çanakkale’de mutlaka görmenizi öneririz.• Seyahatnamelere, türkülere konu olan Aynalı Çarşı Çanakkale’nin simgelerinden biri. Mısır Çarşısı’nın bir küçüğü olarak nitelendirilen Aynalı Çarşı’yı gitmişken görün isterseniz.• Assos Antik Kenti, Antik Liman, Behramkale Köyü ve Athena Tapınağı ile mutlaka görmeniz gereken yerler arasında olan Assos’ta huzuru yakalayacaksınız.• Bozcaada ve Gökçeada’da ise sokaklarda dolaşırken kültürlerin izine her noktada rastlayacaksınız.",
                CityDescription3="• Boğazın bir ucundan diğer ucuna görebileceğiniz İntepe’de ufkunuz açılacak.• Alpler’den sonra dünyanın en fazla oksijen üreten yeri olan Kaz Dağları; Şahindere Kanyonu, Ayazma, Sütüven Göletleri gibi doğal güzellikleri, taş evleri olan köyleri, orman gözetleme kulelerinin yer aldığı manzara noktaları, şifalı suları ile Türkiye’nin görülmesi gereken en değerleri yerlerinden biri. Yolunuz düşerse uğramadan geçmeyin.• Kordon boyunca güzel bir yürüyüş yapabilir, boğazın havasını içine çekip, Gelibolu manzarasına karşı keyifle oturabilirsiniz.• Çanakkale dalış için seçilecek en iyi yerlerden biri. Savaş zamanından kalan batık gemiler ve onları saran deniz canlıları ile farklı bir deneyim yaşayabilirsiniz.• Kazdağları’nın en güzel köyleri Yeşilyurt ve Adatepe‘ye uğramanızı tavsiye ederiz. Özellikle Adatepe’deki Zeus Altarı ve Zeytinyağı Müzesi’ni mutlaka görmelisiniz. Yeşilyurt Köyü’ndeki butik taş otellerde konaklayabilirsiniz.",
                CityDescription4="• Saygın bir çağdaş sanat etkinliği olan Uluslararası Çanakkale Bienali değerli ve önemli ulusal ve uluslararası sanatçıların, sanat ve kültür kurumlarının, sanat eleştirmenleri ve küratörlerin katılım ve iş birlikleriyle hayata geçirilen sanatseverlerin buluştuğu bir etkinlik.• Eskiden hamam olarak kullanılan Seramik Müzesi, Geleneksel Çanakkale Seramikleri’nin geçmişten günümüze olan süreçte gelişimini anlatıyor. Ayrıca müzede atölye ve sergi gibi çeşitli etkinlikler yapılıyor. İsterseniz siz de burada seramik yapma deneyimini yaşayabilirsiniz.• UNESCO tarafından dünya mirası olarak gösterilen Troia Antik Kenti’nden adını alan Uluslararası Troia Festivali; tarih, kültür, sanat, barış ve gelecek gibi konuları ele alan kültürel ve sanatsal etkinlikleri artırmak ve bu birleştirici gücü insanlara yansıtmak amacıyla yapılan keyifli bir festival. Gidiş tarihleriniz ile festival tarihi uyarsa mutlaka katılmanızı öneriyoruz.",
                CityDescription5="• Çanakkale denince akla ilk gelen lezzetler Ezine peyniri, domates ve peynir helvası, ama yöresel yemeklerine bir daldık mı; ovmaç, iskorpit, ıspanak çorbası; tumbi, ıspanak sarması, çırpma, melki yemeği, yumurtalı tiken, metez, tarhanalı patlıcan, börülce köftesi, lüfer pilavı, deli armut turşusu (ahlat turşusu), kaymaklı lorlu biber böreği, kabaklı Saroz böreği ve Gelibolu böreği, piruhi, hıdrellez yahnisi, tavuklu mantı, bakla keşkeği, deve sucuğu ve bitmeyen lezzetleri…• Deniz memleketi olan Çanakkale sardalyesi ile de meşhur. Sardalye balığından yapılan binbir türlü yemeği tatmanızı öneririz.• Kordon’da midye dolmasının en lezzetlisini yiyebilirsiniz.• Bozcaada’da taze deniz ürünleri, adaya özgü otlardan yapılan mezeler ile enfes yemekler yiyebilirsiniz. Bağ bozumuna denk gelirseniz Bozcaada’nın üzümlerini tatmanızı öneririz. Adadan dönerken içi bademli domates reçeli, üzüm reçeli, gelincik reçeli, koruk suyu ve sakızlı bademli kurabiye almadan dönmeyin bizce.• Şehir Müzesi’nin yakınındaki Yalı Hanı içerisinde yer alan kafelerde tatlınızı alıp çayınızın tadını çıkarmanızı tavsiye ederiz."
            },
            new City()
            {
                CityNo=15,
                CityName="Burdur",
                CityImg="Daha Sonra Düzeltilecek",
                CityTitle = "Birçok uygarlığa tanık olmuş Çanakkale’nin asıl tarihi Truva ile başlar." +
                " Bu önemli topraklar üzerine Aiokialıların, Lidyalıların, Perslerin, Anadolu Beyliklerinin, " +
                "Osmanlıların ve başka birçok medeniyetin izleri vardır.",
                CityDescription="ve başka birçok medeniyetin izleri vardır.Geçmişten günümüze taşıdığı köklü tarihi ile Çanakkale; " +
                "Biga ve Gelibolu yarımadaları üzerinde kurulu bir açık hava müzesi. " +
                "Tarihi yaşamışlıkları, arkeolojik eserleri, doğal güzellikleri ile ülkemizin en ilgi çekici şehirlerinden biri. " +
                "Gökçeada, Bozcaada, Assos gibi turizm merkezleri de olan Çanakkale siz gezginlerin buluşması noktası olacak." +
                "Ülkemizin dönüm noktalarından birinin yaşandığı yer, Gelibolu Yarımadası Tarihi Milli Parkı… Kilitbahir Kalesi, " +
                "Seyit Onbaşı Anıtı ve Mecidiye Tabyaları, Çanakkale Şehitler Abidesi, 57. Alay Şehitliği, Conkbayırı, Atatürk Anıtı ve Siperler. " +
                "Fedakarlıklar ve kahramanlıkların yaşandığı, vatan uğruna şehit olan gurur kaynaklarımızı anmadan dönmek olmaz Çanakkale’den.",
                CityDescription2="• Çanakkale Saat Kulesi, Çanakkale Arkeoloji Müzesi, Çanakkale Deniz Müzesi’nde Nusret Mayın Gemisi görmenizi tavsiye ettiğimiz diğer yerlerden.• Ezine ilçesindeki dünyanın en önemli antik kentlerinden Truva Antik Kenti, Truva Savaşları’nın meydana geldiği yer olarak bilinir ve Çanakkale’de mutlaka görmenizi öneririz.• Seyahatnamelere, türkülere konu olan Aynalı Çarşı Çanakkale’nin simgelerinden biri. Mısır Çarşısı’nın bir küçüğü olarak nitelendirilen Aynalı Çarşı’yı gitmişken görün isterseniz.• Assos Antik Kenti, Antik Liman, Behramkale Köyü ve Athena Tapınağı ile mutlaka görmeniz gereken yerler arasında olan Assos’ta huzuru yakalayacaksınız.• Bozcaada ve Gökçeada’da ise sokaklarda dolaşırken kültürlerin izine her noktada rastlayacaksınız.",
                CityDescription3="• Boğazın bir ucundan diğer ucuna görebileceğiniz İntepe’de ufkunuz açılacak.• Alpler’den sonra dünyanın en fazla oksijen üreten yeri olan Kaz Dağları; Şahindere Kanyonu, Ayazma, Sütüven Göletleri gibi doğal güzellikleri, taş evleri olan köyleri, orman gözetleme kulelerinin yer aldığı manzara noktaları, şifalı suları ile Türkiye’nin görülmesi gereken en değerleri yerlerinden biri. Yolunuz düşerse uğramadan geçmeyin.• Kordon boyunca güzel bir yürüyüş yapabilir, boğazın havasını içine çekip, Gelibolu manzarasına karşı keyifle oturabilirsiniz.• Çanakkale dalış için seçilecek en iyi yerlerden biri. Savaş zamanından kalan batık gemiler ve onları saran deniz canlıları ile farklı bir deneyim yaşayabilirsiniz.• Kazdağları’nın en güzel köyleri Yeşilyurt ve Adatepe‘ye uğramanızı tavsiye ederiz. Özellikle Adatepe’deki Zeus Altarı ve Zeytinyağı Müzesi’ni mutlaka görmelisiniz. Yeşilyurt Köyü’ndeki butik taş otellerde konaklayabilirsiniz.",
                CityDescription4="• Saygın bir çağdaş sanat etkinliği olan Uluslararası Çanakkale Bienali değerli ve önemli ulusal ve uluslararası sanatçıların, sanat ve kültür kurumlarının, sanat eleştirmenleri ve küratörlerin katılım ve iş birlikleriyle hayata geçirilen sanatseverlerin buluştuğu bir etkinlik.• Eskiden hamam olarak kullanılan Seramik Müzesi, Geleneksel Çanakkale Seramikleri’nin geçmişten günümüze olan süreçte gelişimini anlatıyor. Ayrıca müzede atölye ve sergi gibi çeşitli etkinlikler yapılıyor. İsterseniz siz de burada seramik yapma deneyimini yaşayabilirsiniz.• UNESCO tarafından dünya mirası olarak gösterilen Troia Antik Kenti’nden adını alan Uluslararası Troia Festivali; tarih, kültür, sanat, barış ve gelecek gibi konuları ele alan kültürel ve sanatsal etkinlikleri artırmak ve bu birleştirici gücü insanlara yansıtmak amacıyla yapılan keyifli bir festival. Gidiş tarihleriniz ile festival tarihi uyarsa mutlaka katılmanızı öneriyoruz.",
                CityDescription5="• Çanakkale denince akla ilk gelen lezzetler Ezine peyniri, domates ve peynir helvası, ama yöresel yemeklerine bir daldık mı; ovmaç, iskorpit, ıspanak çorbası; tumbi, ıspanak sarması, çırpma, melki yemeği, yumurtalı tiken, metez, tarhanalı patlıcan, börülce köftesi, lüfer pilavı, deli armut turşusu (ahlat turşusu), kaymaklı lorlu biber böreği, kabaklı Saroz böreği ve Gelibolu böreği, piruhi, hıdrellez yahnisi, tavuklu mantı, bakla keşkeği, deve sucuğu ve bitmeyen lezzetleri…• Deniz memleketi olan Çanakkale sardalyesi ile de meşhur. Sardalye balığından yapılan binbir türlü yemeği tatmanızı öneririz.• Kordon’da midye dolmasının en lezzetlisini yiyebilirsiniz.• Bozcaada’da taze deniz ürünleri, adaya özgü otlardan yapılan mezeler ile enfes yemekler yiyebilirsiniz. Bağ bozumuna denk gelirseniz Bozcaada’nın üzümlerini tatmanızı öneririz. Adadan dönerken içi bademli domates reçeli, üzüm reçeli, gelincik reçeli, koruk suyu ve sakızlı bademli kurabiye almadan dönmeyin bizce.• Şehir Müzesi’nin yakınındaki Yalı Hanı içerisinde yer alan kafelerde tatlınızı alıp çayınızın tadını çıkarmanızı tavsiye ederiz."
            }
        };
        private static Expedition[] expeditions =
        {
            new Expedition()
            {
                ExpeditionStart="Istanbul",
                ExpeditionStation="Ankara",
                ExpeditionFinish="Niğde",
                Bus = buses[0],
                ExpeditionDate="2022-06-17",
                ExpeditionHour="21:00",
                ExpeditionPrice=400
            },
            new Expedition()
            {
                ExpeditionStart="Istanbul",
                ExpeditionStation="Bursa",
                ExpeditionFinish="Ankara",
                Bus = buses[1],
                ExpeditionDate="2022-06-15",
                ExpeditionHour="22:00",
                ExpeditionPrice=200
            },
            new Expedition()
            {
                ExpeditionStart="Burdur",
                ExpeditionStation="Bursa",
                ExpeditionFinish="Istanbul",
                Bus = buses[2],
                ExpeditionDate="2022-06-05",
                ExpeditionHour="13:00",
                ExpeditionPrice=510
            }
        };
        private static TicketSales[] ticketSales =
        {
            new TicketSales()
            {
                Expedition=expeditions[0],
                SeatNumber=4,
                customerName="Osman",
                customerSurname="Ceylan",
                customerTelNo="5355989987",
                customerTcNo="32432"
            },
            new TicketSales()
            {
                Expedition=expeditions[1],
                SeatNumber=4,
                customerName="Osman",
                customerSurname="Ceylan",
                customerTelNo="5355989987",
                customerTcNo="32432"
            },
            new TicketSales()
            {
                Expedition=expeditions[2],
                SeatNumber=4,
                customerName="Osman",
                customerSurname="Ceylan",
                customerTelNo="5355989987",
                customerTcNo="32432"
            }
        };
    }
}
