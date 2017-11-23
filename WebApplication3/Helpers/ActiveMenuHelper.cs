using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace WebApplication3.Helpers
{
    public static class ActiveMenuHelper
    {
        public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");
            var currentArea = htmlHelper.ViewContext.RouteData.DataTokens["area"];
            var builder = new TagBuilder("li")
            {
                InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName, routeValues, htmlAttributes).ToHtmlString()
            };

            if (String.Equals(controllerName, currentController, StringComparison.CurrentCultureIgnoreCase) && String.Equals(actionName, currentAction, StringComparison.CurrentCultureIgnoreCase))
                builder.AddCssClass("active");

            return new MvcHtmlString(builder.ToString());
        }
    }
}

/*
 * Learning LINK: https://www.udemy.com/crystal-reports-an-introduction/learn/v4/t/lecture/5206290?start=0
 How does Sap Crystal Report Works:
 1. It is just a reporting tool so we need to give it a datasource from where it needs to fetch the data.
 2. Because Crystal Report does not store data by itself.
 3. so make the connection with the database first.
 4. after selecting the database you need to select the tables you want. in tables you also need to select the columns you
 want in the reprt. then click finish and you will be all set.
 5. Filed explorer is just5 like solution explorer, you can select the tables/coluimns you want on report dirstly from here too.
 6. a tick mark in the field explorer means that : that column is being used in the report.
 7. you can switch from design to preview back and forth so that you can see the chages then and there.
  8. we have 2 options, either we can save report along with the adata or we dcan save ijust the rrport w/o any data. Actaully saving
  wihtout any data is more secure but savin a reporrt t with data is more helopful as we cdan rpeview the actual report.
  
    9. If you want to create a new datgabse connection to a new DB then you can CLICK ON dATABASE -> AND THEN set dATAbase
    location.
    10. also use database links tabs to set the left outer, inner join, right outer join and all of that.
    
    SORTING THE DATA:
    - Suppose you want to sort the data using any column field, the go to "Record Sort Expert" and then choose ascending and
    descending.
    
    - Group by
    Now suppse you want to group by then go to group exspert asnd select the column also it will sort too. Also you can selec
    here yopu want the group to be created each week, each second, each year and so on. 
    
    Each gvroup has a header a footer and the details ofcourse like below
    G Formula
    G Header: ************************
    Details: 12
             124
              34
    G Footer: ========================

    Now ideally the group by will be done by lets say Date column but you can put anything as the G Header to display there.
    
       -> Repeat group header on each page is very important. If we have grouped by date and if we somehow go to next page and 
       the header is not there then we will have to come back to previous page t o check the date but we go to group expert
       and option and can select show group header on each page option.

    GROUP BY multiple: also we can apply multiple grouping like below:
    groupbydate and then groupby company

    12/23/1007
    - cts
        12
        12
        123
        34
    - cts
        wer
        wer
        wer
    - tcs
        asd
        asdf
        asd

    12/3/2007
    - cts
        1
        15
        34
        123
        - cts
        wer
        wer
        wer
    - tcs
        asd
        asdf
        asd


    Also we can now apply sorting also in it, so supose we say that sort by number then below will be the output
    
    12/23/1007
    - cts
        12
        12
      
        34
          123
    - cts
        wer
        wer
        wer
    - tcs
        asd
        asdf
        asd

    12/3/2007
    - cts
        12
        12
        123
        34
    - cts
        wer
        wer
        wer
    - tcs
        asd
        asdf
        asd


    CONCLUISION: so first group by date , and then group by copmpany and then sort by value

    IMPORTANT: IN group selector you can select how you want to group by supose you group by date then
    date header will show as soon as new date comes in report. But you can say that group by date bu show the
    header only when there is a month change.



    -- FILTER RECORD: they want only some records to show I mean only record > 1000

    We need to go to Select Expert and choose the column name and what ever we want. for example >100 or >500 or = 100
    and so on.

    So we have Group Expert, Sort Expert and Filter Expert till now.

    // Look for the tick Mark in the Field Explorer, that tick mark suggests that trhose fields are being used in the report.

    // FORMAT EDITOR: for formatting font and colour and all of that use format editor
    you can format which typeof datre format you want to be displayed
    - we can ad the hover text also, border dashed, lined and all of that.
    - Alignment: we can change the alignment inside the box for value to displayt
    - Can grow option : When you think that a ine is taking more than its space then the texts will grow to the next line isntead of
    HIDING itself or cutting

    // supress if duplicated: it will show the value just once and will hide the rest of the values, untill its changed.
    if its not checked then if values are same in different rows for same column it will keep on showing repetitevely.

    // For inserting text box go to insert and add the textbox and size it accordingly.

    // Report Header appears just once no matter how many page the report is of
    // Same with report footer
    // Page header and footer comes in every page/
    // To insert line  like ----- or box all this can be done via Insert Menu Option.
    // Format Painter is Awesome: You can use it to style different element as same. SO basicaly you have one text
    filed as itlaics and other one as BOld. and you want both to be bold. You can just select the bols textbox and click the format
    and then clikc the format painter and then click on the italics one and thats it. ALl the stying element of bold one
    will get applied to to the italics texta nd obviouly it will be bold now.
    **************Aligning stuff together
    Align stuff together: Sleect two object that you want to align using control and then go to format then lcikc on alognj
    and thne align them accordingly.
    Or make same size, width and all of that

    **************Adding Additional Section
    * Section Expert
    * You can addiitonal section in the report but going to Report->section expert and add a section where ever you want.
    * *********Formatting Section
    * 
    * Filter/Select Expert: PARAMETER: Suppose we want a record to be greater than 100 then we can add a filter record,
    * but suppose we want the user itself to add a value he wants to filter upon, then in that case we need to add the
    * Paramter. for that we need to go to the field explorer and find the parameter expert and add the stuuf there.
    * And now if we go to the filter expert there we can add that paarametyer as as filter.  now efverytime user
    * opens the report a pop up will show asking him to refine the serrach or filter the report
    * Now in the paremeter adginw in down window there are certain options int he bottom you can use it they are also very useful.
    * like setting default value whne user opens the report.
    * KINDLY KEEP AN EYE FOR GREEN TICK MARK  in the parameter section ONCER YOU ADD A FILTER AND PARAMETER. it helps to execute the report
    * you just created.
    * We can do CHARTS also, leave it for now. go through tutorial if you need to draw graphs
    * SubReport- Drill Through Report
    * DRILL DOWN
    * So, go to section expert and use checkbox: Hide(Drill Down Ok) and now that section will be hidden from main report
    * and whne one double clicks it then that report will be shown alog witht he hidden section.
    * Always rememeber you need to click on group header to open the drill down report.
    * FORMULA : 
    * TO add formula you need to go to formula expert in field explorer and add a formulat that you want.
    * basially may be concateing two string or niumber or wahtever and drag drop it on the report where evern you want.
    * SPECIAL FIELDS: you can go to special field in field exploere and drag drop it into reports and it will be rendered
    * on the report just like Page 3 of 10.
    * 

     */
