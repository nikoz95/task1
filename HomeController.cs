﻿using System;
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
            ////////////////////////////////////////////////////////ORIGINAL

            List<TextRow> _items = new List<TextRow>();
            List<TextWord> _itemsWord = new List<TextWord>();

            List<TextRow> _itemsCH = new List<TextRow>();
            List<TextWord> _itemsWordCH = new List<TextWord>();


            string[] stringSeparators = new string[] { "\r\n" ," "};

            string[] textsOneRow = texts.stringOne.Split(new string[] { stringSeparators[0] }, StringSplitOptions.None);
            string[] textsTwoRow = texts.stringTwo.Split(new string[] { stringSeparators[0] }, StringSplitOptions.None);

            //string[,] text1 = new string[,]
            //{
            //    {"რომელმან შექმნა სამყარო ძალითა მით ძლიერითა," },
            //    {"ზეგარდმოთ არსნი სულითა ყვნა ზეცით მონაბერითა," },
            //    {"ჩვენ, კაცთა, მოგვცა ქვეყანა, გვაქვს უთვალავი ფერითა," },
            //    {"მისგან არს ყოვლი ხელმწიფე სახითა მის მიერითა" }

            //};

            //string[,,] text1Split = new string[,,]
            //{
            //    {{"რომელმან" }, {"შექმნა" },{"სამყარო" },{"მით" },{"ძლიერითა" },{"მით" },{"ჩამატებული" }},
            //    {{"ზეგარდმოთ" }, {"არსნი" },{"სულითა" },{"ყვნა" },{"ზეცით" },{"მონაბერითა" },{"ჩამატებული" }},
            //    {{"ჩვენ" },{"კაცთა" },{"მოგვცა" },{"ქვეყანა" },{"გვაქვს" },{"უთვალავი" },{"ფერითა"}},
            //    {{"მისგან" }, {"არს" },{"ყოვლი" },{"ხელმწიფე" },{"სახითა" },{"მის" },{"მიერითა" }}

            //};
            //string[][] jaggedArray3 =
            //{
            //    new string[]{  "რომელმან შექმნა სამყარო ძალითა მით ძლიერითა,",  "რომელმან", "შექმნა", "სამყარო", "ძალითა", "მით", "ძლიერითა" },
            //    new string[]{  "ზეგარდმოთ არსნი სულითა ყვნა ზეცით მონაბერითა," , "ზეგარდმოთ" , "არსნი" ,"სულითა" ,"ყვნა" ,"ზეცით" ,"მონაბერითა" },
            //    new string[]{  "ჩვენ, კაცთა, მოგვცა ქვეყანა, გვაქვს უთვალავი ფერითა," ,  "ჩვენ" ,  "კაცთა" ,  "მოგვცა" , "ქვეყანა" ,  "გვაქვს" ,  "უთვალავი" ,  "ფერითა"  },
            //    new string[]{  "მისგან არს ყოვლი ხელმწიფე სახითა მის მიერითა" , "მისგან" ,  "არს" ,  "ყოვლი" ,  "ხელმწიფე" ,  "სახითა" ,  "მის" ,  "მიერითა"  }
                
            //};
            //string[,] jaggedText = new string[,] { };

            //for (int i = 0; i < textsOneRow.Length; i++)
            //{
            //    string[] SplitRowW = textsOneRow[i].Split(stringSeparators, StringSplitOptions.None);
            //    for (int j = 0; j < SplitRowW.Length; j++)
            //    {
            //        string[,] jaggedText1 =   new string[,] {{ textsOneRow[i], SplitRowW[j] } };
            //        jaggedText[i, 0] = textsOneRow[i];
            //        jaggedText += jaggedText1;


                    
                    
                    
            //    }
            //}


            //List<Result> _result = new List<Result>();

                //try
                //{
                        //for (int i = 0; i < 50; i++)
                        //{
                        //    string[] SplitRow = new string[] { };
                        //    string[] SplitRowCH = new string[] { };
                            //_items.Add(new TextRow { RowId = i, RowText = textsOneRow[i] });
                            //if (textsOneRow[i].Count() < textsTwoRow[i].Count())
                            //{
                    
                            //    SplitRowCH = textsTwoRow[i].Split(stringSeparators, StringSplitOptions.None);
                            //    Array.Resize(ref textsOneRow, textsOneRow.Length + 1);
                            //    textsOneRow[textsOneRow.Length - 1] = "new string new string new string new string new string new string new string";

                            //}
                            //else
                            //{
                                //SplitRow = textsOneRow[i].Split(stringSeparators, StringSplitOptions.None);
                                //SplitRowCH = textsTwoRow[i].Split(stringSeparators, StringSplitOptions.None);

                            //}
                
                                //for (int j = 0; j < 50; j++)
                                //{

                                    //if (SplitRow.Count() < SplitRowCH.Count())
                                    //{
                                    //    _result.Add(new Result
                                    //    {
                                    //        RowId = i,
                                    //        RowTextOr = textsOneRow[i].Length > 0 ? textsOneRow[i] : "jj",
                                    //        RowTextCh = textsTwoRow[i],
                                    //        WordId = j,
                                    //        WordOr = textsOneRow[i].Length > j ? SplitRow[j] : "<<WordOr",
                                    //        WordCh = textsTwoRow[i].Length > j ? SplitRowCH[j] : "<<WordCh",
                                    //        Status = "wrong",
                                    //    });
                                    //    k++;
                                    //}
                                    //else if (SplitRow.Count() > SplitRowCH.Count())
                                    //{

                                    //    _result.Add(new Result
                                    //    {
                                    //        RowId = i,
                                    //        RowTextOr = textsOneRow[i].Length > 0 ? textsOneRow[i] : "jj",
                                    //        RowTextCh = textsTwoRow[i],
                                    //        WordId = j,
                                    //        WordOr = textsOneRow[i].Length > j ? SplitRow[j] : "WordOr>>",
                                    //        WordCh = textsTwoRow[i].Length > j ? SplitRowCH[j] : "WordCh>>",
                                    //        Status = "wrong",
                                    //    });


                                    //}
                                    //else {
                       
                                //_result.Add(new Result
                                //    {
                                //        RowId = i,
                                //        RowTextOr = textsOneRow[i].Length > 0 ? textsOneRow[i] : "jj",
                                //        RowTextCh = textsTwoRow[i],
                                //        WordId = j,
                                //        WordOr = textsOneRow[i].Length > j ? SplitRow[j] : "jj",
                                //        WordCh = SplitRowCH[j],
                                //        Status = SplitRowCH[j] == SplitRow[j] ? "correct" : "wrong",
                                //    });

                        
                                    //}
                                //}
                        //}

            //}
            //catch (System.IndexOutOfRangeException ex)
            //{
            //    string input1 = "";
            //}
            //gansazgvre udidesi
            //for (int i = 0; i < textsTwoRow.Length; i++)
            //{
            //    _itemsCH.Add(new TextRow { RowId = i, RowText = textsTwoRow[i] });
            //    string[] SplitRowCH = textsTwoRow[i].Split(stringSeparators, StringSplitOptions.None);
            //    for (int j = 0; j < SplitRowCH.Length; j++)
            //    {
            //        _itemsWordCH.Add(new TextWord { WordId = j, RowText = SplitRowCH[j], RowIdFR = i });
            //    }
            //}
            //for (int i = 0; i < _itemsCH.Count(); i++)
            //{

            //    string[] split = _itemsCH[i].RowText.Split(stringSeparators, StringSplitOptions.None);
            //    for (int j = 0; j < split.Length; j++)
            //    {

            //        _result.Add(new Result
            //        {
            //            RowId = i,
            //            RowTextOr = _items[i].RowText,
            //            RowTextCh = _itemsCH[i].RowText,
            //            WordId = j,
            //            WordOr = _itemsWord[j].RowText,
            //            WordCh = _itemsWordCH[j].RowText,
            //            Status = _itemsWord[j].RowText == _itemsWordCH[j].RowText ? "correct" : "wrong",
            //        });
            //    }

            //}
            ////////////////////////////////////////////////////////////////////////////
            //var query =
            //           from itemRow in _items
            //           join itemword in _itemsWord on itemRow.RowId equals itemword.RowIdFR
            //           //where post.ID == id
            //           select new {
            //                       RowId =itemRow.RowId,
            //                       RowText = itemRow.RowText,
            //                       WordId = itemword.WordId,
            //                       Word = itemword.RowText
            //                      };
            ////////////////////////////////////////////////////////CHANGE
            List<TextWord> _textOr = new List<TextWord>();
            List<TextWord> _textCh = new List<TextWord>();
            List<TextWord> mistake = new List<TextWord>();
            List<TextWord> mistake1 = new List<TextWord>();
            List<TextWord> group = new List<TextWord>();
            List<List<TextWord>> diss = new List<List<TextWord>>();
            //var settings = new List<string[]>();
            List<List<String[]>> _SecLocations = new List<List<String[]>>{
                
                new List<String[]> { new string[]{"Item1", "Item2", "Item3", "Item4"}},
                new List<String[]> {  new string[]{"Item1", "Item2", "Item3", "Item4"}},
               
            };
            List<string> dis = new List<string>();

            for (int i = 0; i < textsOneRow.Length; i++)
            {
                string[] split = textsOneRow[i].Split(stringSeparators, StringSplitOptions.None);
                for (int j = 0; j <split.Length ; j++)
                {
                    _textOr.Add(new TextWord
                    {
                        RowIdFR = i,
                        Text = textsOneRow[i],
                        WordId = j,
                        RowText = split[j]
                    });
                    //dis.Add(_textOr.ToString());
                    diss.Add(_textOr);
                }

            }
            for (int i = 0; i < textsTwoRow.Length; i++)
            {
                string[] split = textsTwoRow[i].Split(stringSeparators, StringSplitOptions.None);
                for (int j = 0; j < split.Length; j++)
                {
                    _textCh.Add(new TextWord
                    {
                        RowIdFR = i,
                        Text = textsTwoRow[i],
                        WordId = j,
                        RowText = split[j]
                    });
                }

            }
            var difList = _textOr.Where(a => !_textCh.Any(a1 => a1.RowText == a.RowText))
            .Union(_textCh.Where(a => !_textOr.Any(a1 => a1.RowText == a.RowText)));
            //var difLis1t = _textOr.Where(item => _textCh.Contains(item.RowText));
           
            for (int i = 0; i < _textOr.Count; i++)
            {
                if (!_textOr[i].RowText.Contains(_textCh[i].RowText))
                {
                    mistake.Add(_textCh[i]);
                } 
            }

            //try
            //{
            //    for (int i = 0; i < _textCh.Count; i++)
            //    {
            //        //var groupedCustomerList = mistake.GroupBy(u => u.RowIdFR).Select(grp => grp.ToList()).ToList();



            //        var l = textsOneRow[i].Count();
            //        if (mistake[i].RowIdFR != _textOr[i+l].RowIdFR)
            //        {

            //            if (!_textOr[i].RowText.Contains(_textCh[i].RowText))
            //            {
            //                mistake1.Add(_textCh[i]);
            //            }

            //        }
            //    }
            //}
            //catch (System.ArgumentOutOfRangeException ex)
            //{
            //    string input1 = "";
            //}
                    

                        
                    
                
               
            
        
            Console.WriteLine(mistake);
            Console.WriteLine(mistake1);
            ////////////////////////////////////////////////////////////////////////////////
            //var queryCH =
            //           from itemRow in _itemsCH
            //           join itemword in _itemsWordCH on itemRow.RowId equals itemword.RowIdFR
            //           //where post.ID == id
            //           select new
            //           {
            //               RowId = itemRow.RowId,
            //               RowText = itemRow.RowText,
            //               WordId = itemword.WordId,
            //               Word = itemword.RowText
            //           };
            ///////////////////////////////////////////////////////////////////////////


            //_itemsCH.AddRange(_itemsWordCH);
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


            // var list = query.Select().Concat(queryCH.Where(x => true));



            // Console.WriteLine(_result);



            //ViewData["Result"] = result.ToList();
            return View();
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
