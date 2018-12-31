var init = function()
{
    console.log("the party just started.");

    $("#eat-list").on("click", "li", eatFromTheListEvent)
    $("#burger-form").on("submit", addNewBurger);
}

var eatFromTheListEvent = function()
{
    var burger = $(this);
    var index = burger.attr("data-index");
    var options = {
        contentType: "application/json; charset=utf-8",
        method: "PUT",
        data: JSON.stringify({ devoured: true })
    }

    $.ajax("/api/burger/edit/" + index, options).then(function(result) 
    {
        //result = JSON.parse(result);
        if(result)
        {
            burger.appendTo(".devoured");
        }        
    })
}

var addNewBurger = function(event)
{
    event.preventDefault();
    var burger = $("#burger-name").val().trim();

    if(!burger) return;

    var options = {
        contentType: "application/json; charset=utf-8",
        method: "POST",
        data: JSON.stringify({ burgerName: burger })
    };

    $.ajax("/api/burger/add", options).then(function(result) 
    {
        //result = JSON.parse(result);
        if(result)
        {
            var newBurger = $("<li>");
            newBurger.text(result.burgerName);
            newBurger.attr("data-index", result.id);
            newBurger.appendTo("#eat-list");
        }
    });
}



