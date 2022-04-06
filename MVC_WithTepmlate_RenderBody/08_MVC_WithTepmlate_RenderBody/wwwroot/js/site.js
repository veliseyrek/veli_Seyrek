$(document).ready(function () {

    $("li a").each(function () {
        if ($(this).attr("href") == window.location.pathname) {
            $(this).addClass("activeLink");
            console.log($(this).addClass("activeLink"));
        }
    })
    //$("li a").attr("href")
    //console.log($("li a").attr("href"));
    //console.log(window.location.pathname);
})
