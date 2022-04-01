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
     $("#1-1").css("display","block");
 })
 $("#1-1-1").click(function(){
      $("1-1").css("display","none")
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