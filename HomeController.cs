using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextComparator.models;
using System.Text;
using TextComparator.Controllers.ForLists;
using TextComparator.Controllers.ForList;

namespace TextComparator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Text texts)
        {
            string[] stringSeparators = new string[] { "\r\n" ," "};

            string[] textsTwoRow = texts.stringTwo.Split(new string[] { stringSeparators[0] }, StringSplitOptions.None);
            string[] textsOneRow = texts.stringOne.Split(new string[] { stringSeparators[0] }, StringSplitOptions.None);
           
           
            ////////////////////////////////////////////////////////ORIGINAL
            List<TextRow> _items = new List<TextRow>();
            List<TextWord> _itemsWord = new List<TextWord>();
            for (int i = 0; i < textsOneRow.Length; i++)
            {
                _items.Add(new TextRow { RowId = i, RowText = textsOneRow[i] });
                string[] SplitRow = textsOneRow[i].Split(stringSeparators, StringSplitOptions.None);
                for (int j = 0; j < SplitRow.Length; j++)
                {
                    _itemsWord.Add(new TextWord { WordId = j, RowText = SplitRow[j], RowIdFR = i });
                }
            }

            var query =
                       from itemRow in _items
                       join itemword in _itemsWord on itemRow.RowId equals itemword.RowIdFR
                       //where post.ID == id
                       select new {
                                   RowId =itemRow.RowId,
                                   RowText = itemRow.RowText,
                                   WordId = itemword.WordId,
                                   Word = itemword.RowText
                                  };
            ////////////////////////////////////////////////////////CHANGE
            List<TextRow> _itemsCH = new List<TextRow>();
            List<TextWord> _itemsWordCH = new List<TextWord>();
            for (int i = 0; i < textsTwoRow.Length; i++)
            {
                _itemsCH.Add(new TextRow { RowId = i, RowText = textsTwoRow[i] });
                string[] SplitRowCH = textsTwoRow[i].Split(stringSeparators, StringSplitOptions.None);
                for (int j = 0; j < SplitRowCH.Length; j++)
                {
                    _itemsWordCH.Add(new TextWord { WordId = j, RowText = SplitRowCH[j], RowIdFR = i });
                }
            }

            var queryCH =
                       from itemRow in _itemsCH
                       join itemword in _itemsWordCH on itemRow.RowId equals itemword.RowIdFR
                       //where post.ID == id
                       select new
                       {
                           RowId = itemRow.RowId,
                           RowText = itemRow.RowText,
                           WordId = itemword.WordId,
                           Word = itemword.RowText
                       };
            ///////////////////////////////////////////////////////////////////////////


            //var result =
            //                from original in query
            //                from change in queryCH
            //                where original.RowId == change.RowId && original.WordId == change.WordId
            //                select new
            //                {
            //                    RowId = original.RowId,
            //                    RowText = original.RowText,
            //                    RowTextCH = change.RowText,
            //                    WordId = original.WordId,
            //                    Word = original.Word,
            //                    WordCH = change.Word,
            //                    status = original.Word == change.Word ? "correct" : "wrong",
            //                    //status = "correct"
            //                };

            var result = query.Concat(queryCH);
            //var list = query.Select().Concat(queryCH.Where(x => true));
                                

            Console.WriteLine(query);
            Console.WriteLine(queryCH);
            Console.WriteLine(result);



            ViewData["Result"] = result.ToList();
            return View(ViewData["Result"]);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
