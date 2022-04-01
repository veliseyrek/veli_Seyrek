let allSlides = $(".slide").toArray();
let slideIndex = 0;
$(document).ready(function(){
    $(".btn-1").mousemove(function(){
            $(".btn-proje").css("display","block"); 
        })
    $(".btn-1").mouseleave(function(){
            $(".btn-proje").css("display","none"); 
        })
   $(".slide").eq(0).css("display","block")

   $(".nextSlide").click(function(){
    // slideIndex++;
    if(allSlides.length==slideIndex+1){slideIndex=-1}
     showSlide(++slideIndex);   
 })
 
 $(".prevSlide").click(function(){
     //slideIndex--;
    if(slideIndex==0){slideIndex=allSlides.length}
     showSlide(--slideIndex);
 })


 






 $("#1").click(function(){
     $("#1-2").show();
 })

 $("#1-4").click(function(){
    $("#1-2").hide();
   // $(".container").css("display","block");
})

// $(".footer-1").click(function(e){
//     $().show();
// })
//  $(".close-popup").click(function(){
//       $(".main-popup").hide();
//      // $(".container").css("display","block");
//  })
//  $(".main-popup").click(function(){
//     $("#footer-1").hide();
//    // $(".container").css("display","block");
// })


 $("#2").click(function(){
    $("#2-2").show();
})
$("#2-4").click(function(){
     $("#2-2").hide();
    // $(".container").css("display","block");
})

$("#3").click(function(){
    $("#3-2").show();
})
$("#3-4").click(function(){
     $("#3-2").hide();
    // $(".container").css("display","block");
})

$("#4").click(function(){
    $("#4-2").show();
})
$("#4-4").click(function(){
     $("#4-2").hide();
    // $(".container").css("display","block");
})

$("#5").click(function(){
    $("#5-2").show();
})
$("#5-4").click(function(){
     $("#5-2").hide();
    // $(".container").css("display","block");
})




})
function showSlide(n){
    for(let i=0; i<allSlides.length; i++){
        allSlides[i].style.display="none";     
        //$(allSlides[i]).hide()
    }
    
    
    allSlides[n].style.display="block";
    //$(allSlides[n]).show()
}


    
showSlide(slideIndex);