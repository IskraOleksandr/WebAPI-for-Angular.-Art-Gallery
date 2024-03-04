﻿using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Art_Gallery_WebAPI.Models
{
    public class ArtGalleryContext : DbContext
    {
        public DbSet<ArtWork> ArtWorks { get; set; }
        public ArtGalleryContext(DbContextOptions<ArtGalleryContext> options)
            : base(options)
        {
            if (Database.EnsureCreated())
            {
                ArtWorks.Add(new ArtWork
                {
                    Title = "Мона Лиза",
                    Year = "1503—1519",
                    Author = "Леонардо да Винчи",
                    Size = "76,8 × 53 см",
                    Location = "Лувр, Париж",
                    Img = "../assets/Mona_Lisa.jpg",
                    Plot = "«Мона Лиза представлена сидящей в кресле на фоне пейзажа, и уже само сопоставление её сильно приближённой к зрителю фигуры с видимым издалека, как бы огромной горы, ландшафтом сообщает образу необыкновенное величие. Этому же впечатлению содействует контраст повышенной пластической осязательности фигуры и её плавного, обобщённого силуэта с уходящим в туманную даль, похожим на видение пейзажем с причудливыми скалами и вьющимися среди них водными протоками»"
                });
                ArtWorks.Add(new ArtWork
                {
                    Title = "Ирисы",
                    Year = "1889",
                    Author = "Ван Гог",
                    Size = "71 × 93 см",
                    Location = "Музей Гетти, Лос-Анджелес",
                    Img = "../assets/Irises.jpg",
                    Plot = "В картине отсутствует высокая напряжённость, которая проявляется в его последующих работах. Он назвал картину «громоотвод для моей болезни», потому что он чувствовал, что может сдерживать свой недуг, продолжая писать. В картине прослеживается влияние японских гравюр укиё-э, как и в других работах Ван Гога и части его современников. Это сходство проявляется в выделении контуров объектов, необычных ракурсах, наличии детально прорисованных областей, залитых сплошным цветом, не соответствующим реальности."
                });
                ArtWorks.Add(new ArtWork
                {
                    Title = "Крик",
                    Year = "1893",
                    Author = "Эдвард Мунк",
                    Size = "91 × 73,5 см",
                    Location = "Национальная галерея, Осло",
                    Img = "../assets/The_Scream.jpg",
                    Plot = "Фигура кричащего примитивизирована до такой степени, что напоминает различным комментаторам скелет. Волнообразные линии пейзажа, будто эхо, повторяют закруглённые контуры головы и широко раскрытого рта — как если бы звук крика отдавался повсюду. Негативная эмоция субъекта, таким образом, подминает под себя окружающий мир, приобретая вселенский размах. Но возможно и обратное прочтение: человек агонизирует по поводу раздающегося отовсюду, как выразился сам художник, «крика природы»."
                });

                ArtWorks.Add(new ArtWork
                {
                    Title = "Девушка с жемчужной серёжкой",
                    Year = "1665",
                    Author = "Ян Вермеер",
                    Size = "44,5 × 39 см",
                    Location = "Маурицхёйс, Гаага",
                    Img = "../assets/Girl with a pearl earring.jpg",
                    Plot = "Художник попытался запечатлеть момент, когда девушка поворачивает голову в сторону зрителя к кому-то, кого она только что заметила. В соответствии с названием внимание зрителя фокусируется на жемчужной серёжке в ухе девушки. В настоящее время ряд исследователей ставит под сомнение, что на картине изображена жемчужная серёжка. Для натурального жемчуга размер слишком велик, это может быть фальшивый жемчуг из венецианского стекла или перламутра. Кроме того, не видно петли или подвески, за которую «жемчужина» крепится к уху. Яркий белый блик вверху «серёжки» может быть деформацией при одной из реставраций картины."
                });
                ArtWorks.Add(new ArtWork
                {
                    Title = "Звёздная ночь",
                    Year = "1889",
                    Author = "Винсент ван Гог",
                    Size = "73,7 × 92,1 см",
                    Location = "Музей современного искусства, Нью-Йорк",
                    Img = "../assets/Starry_Night.jpg",
                    Plot = "одна из наиболее известных картин нидерландского художника-постимпрессиониста Винсента Ван Гога. Представляет вид из восточного окна спальни Ван Гога в Сен-Реми-де-Прованс на предрассветное небо и вымышленную деревню."
                });
                ArtWorks.Add(new ArtWork
                {
                    Title = "Постоянство памяти",
                    Year = "1931",
                    Author = "Сальвадор Дали",
                    Size = "24 × 33 см",
                    Location = "Музей современного искусства, Нью-Йорк",
                    Img = "../assets/The_Persistence_of_Memory.jpg",
                    Plot = "Известна также как «Мягкие часы», «Утекающее время», «Твердость памяти» или «Стойкость памяти» или «Течение времени» или «Время». Эта небольшая картина (24х33 см) — вероятно, самая известная работа Дали. Размягченность висящих и стекающих часов — образ, выражающий уход от линейного понимания времени. Здесь присутствует и сам Дали в виде спящей головы, уже появлявшейся в «Траурной игре» и других картинах."
                });
                SaveChanges();
            }
        }
    }
}