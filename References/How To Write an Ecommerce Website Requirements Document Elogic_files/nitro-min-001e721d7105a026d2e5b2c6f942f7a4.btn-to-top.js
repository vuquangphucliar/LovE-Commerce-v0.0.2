(function(){"use strict";function t(){var t=window.pageYOffset;var e=document.documentElement.clientHeight;if(t>e){o.classList.add("btn_to_top-show")}if(t<e){o.classList.remove("btn_to_top-show")}}function e(){if(window.pageYOffset>0){window.scrollBy(0,-80);setTimeout(e,17)}}var o=document.querySelector(".btn_to_top");window.addEventListener("scroll",t);o.addEventListener("click",e)})();