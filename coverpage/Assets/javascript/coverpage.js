console.log("comeon!")

$(document).ready(function () {
    console.log("first here")
    $(".article-title").mouseover(function (event) {
        console.log(event);
        $(event.target).css("background-color", "blue");
    });
    $(".article-title").mouseout(function (event) {
        console.log("out!");
        $(event.target).css("background-color", "white");
    });

    $(".like-button").click(function (event) {
        var element = event.target;
        var imgid = $(element).attr("id");
        var articleid = imgid.split("-")[2];
        console.log(articleid);
        $.ajax(
                {
                    url: "ajax/like?articleid=" + articleid,
                    type: "POST",
                    success: function (response) {
                        console.log(response);
                        $("#like-count-" + articleid).html(response.count);
                    }
                }
            );
        
    })

});