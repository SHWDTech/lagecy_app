using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

namespace Web
{
    public class CommonPage
    {
        //private static int pageSum;                //总的页数
        //private static int recordsCout;            //总的记录条数
        //private static int curPage;                //当前页
        private static int pageSize = 10;         //每页要显示的条数
        private static int showPage = 5;          //数字导航条要显示页码的个数

        public static int GetPageSize()
        {
            return pageSize;
        }

        /// <summary>
        /// 获取页码范围，设置样式
        /// </summary>
        /// <param name="recordsCout">总的记录条数</param>
        /// <param name="pageSum">总的页数</param>
        /// <param name="curPage">当前页</param>
        /// <returns></returns>
        public static string SetPage(int recordsCout, int curPage)
        {
            string pageStyle = string.Empty;

            int minPage = 0;//要显示的页面数最小值
            int maxPage = 0;//要显示的页面数最大值
            int pageSum = 0;//总的页数

            //计算总页数
            if (recordsCout % pageSize == 0)
            {
                pageSum = recordsCout / pageSize;
            }
            else
            {
                pageSum = recordsCout / pageSize + 1;
            }
            //自动适应分页范围
            //注意，这段代码就是你要的


            if (curPage > pageSum)//当前页必须小于最大页
            {
                curPage = pageSum;
            }

            if (curPage % showPage == 0) //如果恰好整除
            {
                minPage = curPage;
                maxPage = curPage + showPage;
            }
            else if (curPage % showPage == 1 && curPage > showPage)
            {
                //minPage = curPage - showPage + 1;
                minPage = (((int)curPage / showPage) - 1) * showPage + 1;
                maxPage = curPage;
            }
            else
            {
                minPage = ((int)curPage / showPage) * showPage + 1;
                maxPage = (((int)curPage / showPage) + 1) * showPage;
            }

            pageStyle = GetPageStyle(recordsCout, pageSum, curPage, minPage, maxPage);

            return pageStyle;
        }

        private static string GetPageStyle(int recordsCout, int pageSum, int curPage, int minPage, int maxPage)
        {
            StringBuilder sb = new StringBuilder();

            //循环组装页码html
            if (curPage == 1)
            {
                sb.Append("<span class=\"current prev\">上一页</span>");
            }
            else
            {
                sb.AppendFormat("<a class=\"prev\" href=\"javascript:void(0)\" onclick=\"goto({0},{1})\">上一页</a>", curPage - 1, recordsCout);
            }

            for (int i = minPage; i <= maxPage; i++)
            {
                if (i <= pageSum)//只有不大于最大页才显示
                {
                    if (curPage == i) //当前页
                    {
                        sb.AppendFormat("<span class=\"current\">{0}</span>", i);
                    }
                    else
                    {
                        sb.AppendFormat("<a class=\"prev\" href=\"javascript:void(0)\" onclick=\"goto({0},{1})\">{2}</a>", i, recordsCout, i);
                    }
                }
            }

            if (curPage == pageSum)
            {
                sb.Append("<span class=\"current next\">下一页</span>");
            }
            else
            {
                sb.AppendFormat("<a class=\"prev\" href=\"javascript:void(0)\" onclick=\"goto({0},{1})\">下一页</a>", curPage + 1, recordsCout);
            }

            return sb.ToString();
        }
    }
}
