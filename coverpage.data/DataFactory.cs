using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coverpage.data
{
    public class DataFactory
    {
        private string _language;

        public DataFactory(string language)
        {
            if (language == null)
                _language = "en";
            else
                _language = language;
        }

        public string GetHeadline(int articleId)
        {
            //In real life this is where we'd get stuff from a database
            if (articleId == 1 && _language == "en")
            {
                return "US and Iran sign historic arms deal";
            }
            else if (articleId == 2 && _language == "en")
            {
                return "Carlssen wins world chess championship";
            }
            else if (articleId == 1 && _language == "fr")
            {
                return "Accord entre E.U et Iran";
            }
            else if (articleId == 2 && _language == "fr")
            {
                return "Carlssen gagne a echeques";
            }
            else
            {
                return "Article not found";
            }
        }

        public string GetArticleText(int articleId)
        {
            //In real life this is where we'd get stuff from a database
            if (articleId == 1 && _language == "en")
            {
                return "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            }
            else if (articleId == 2 && _language == "en")
            {
                return "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            }
            else if (articleId == 1 && _language == "fr")
            {
                return "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.";
            }
            else if (articleId == 2 && _language == "fr")
            {
                return "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true gen";
            }
            else
            {
                return "Article not found";
            }

            

        }
    }
}
