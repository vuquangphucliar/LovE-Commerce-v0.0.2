jQuery(document).ready(function(){e();function e(){if(jQuery(".table_of_content_body ul li").length<=0){var e=jQuery(".post-text").find(':header:not("h1"):not(".ct")');var i=jQuery(".table_of_content_body ul");e.each(function(){var e=jQuery(this);if(!e.attr("id")){var t=e.text().replace(/[^A-Z0-9]/gi,"_");e.attr("id",t)}var a=e.prop("tagName");if(a){if(a==="H2"){i.append("<li><a href='#"+e.attr("id")+"'>"+e.text().replace("♦ ","")+"</a></li>")}else{i.append("<li class='child_li'><a href='#"+e.attr("id")+"'>"+e.text().replace("♦ ","")+"</a></li>")}}});window.addEventListener("scroll",function(){e.each(function(){var e=jQuery(this);if(a(e)){var t=e.attr("id");i.find("li a").removeClass("active");i.find('li a[href="#'+t+'"]').addClass("active")}})});function a(e){var t=jQuery(window).scrollTop();var a=t+jQuery(window).height();var i=jQuery(e).offset().top+290;var r=i+jQuery(e).height();return r<=a&&i>=t}}}jQuery(".nsbp-hero-content .table_of_content_section .table_of_content_head").on("click",function(){jQuery(this).toggleClass("sp-hide")})});