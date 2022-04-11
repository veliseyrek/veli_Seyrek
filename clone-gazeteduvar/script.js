var _slayt = document.getElementsByClassName("imagess");
var ball = document.getElementsByClassName("ball-item");
var slaytSayisi = _slayt.length;
var slaytNo = 0;
var i = 0;


slaytGoster(slaytNo);


function sonrakiSlayt() {
    slaytNo++;
    slaytGoster(slaytNo);
  }

  function oncekiSlayt() {
    slaytNo--;
    slaytGoster(slaytNo);
  }
  function slaytGoster(slaytNumarasi) {
    slaytNo = slaytNumarasi;

    if (slaytNumarasi >= slaytSayisi) slaytNo = 0;

    if (slaytNumarasi < 0) slaytNo = slaytSayisi - 1;

    for (i = 0; i < slaytSayisi; i++) {
      _slayt[i].style.display = "none";
      ball[i].classList.remove("active");
    }

    _slayt[slaytNo].style.display = "block";
    ball[slaytNo].classList.add("active");


  }

  $(document).ready(function(){
    $(".span").click(function(){
      $(".span").hide(1000);
        $(".searchh").show(1000);
    })

  })