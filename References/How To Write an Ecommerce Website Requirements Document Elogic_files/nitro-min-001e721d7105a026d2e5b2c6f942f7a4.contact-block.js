$(function(){(function(){const o=$(".form-label").detach();const t=$(".form-wrapper .form__control");o.each(function(o,n){$(n).insertAfter($(t[o]))})})();(function(){const o=$(".icon-wrapper").detach();$(o).insertAfter("#form_footer_input_email")})();(function(){const e=$("#form_footer_input_email");const i=$(".wpcf7-form-control.wpcf7-submit");i.prop("disabled",true);function o(){const o=e.val();const n=/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;const t=n.test(o);e[0].setCustomValidity(t?"":"Wrong email");e.toggleClass("invalid",!t);i.prop("disabled",!t)}if(e.length){e.on("input",o);e.on("focusout",o)}})();(function(){const n=$(".wpcf7-form");$(n).on("wpcf7mailsent",function(o){$(n).on("reset",function(o){o.preventDefault()})})})();(function(){const o="/thank-you";if(window["google_tag_manager"]){$("form").on("wpcf7mailsent",function(){console.log("Is GTM");window.dataLayer=window.dataLayer||[];window.dataLayer.push({event:"form_footer_submit",eventCallback:function(){window.location.href=o}})})}else{$("form").on("wpcf7mailsent",function(){console.error("No GTM");window.location.href=o})}})();$(".wpcf7-submit").on("keydown",function(o){if(o.key==="Enter"){o.preventDefault();$(".wpcf7-submit").trigger("click")}})});