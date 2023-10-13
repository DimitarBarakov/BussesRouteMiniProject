// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let btns = document.querySelectorAll(".showAndHide")
//let moreInfo = document.querySelector(".more")

for (let i = 0; i < btns.length; i++) {
    btns[i].addEventListener("click", ShowAndHideInfo)
}

function ShowAndHideInfo(event) {
    let parent = event.target.parentElement.parentElement;
    let info = parent.querySelector('.more')
    if (event.target.textContent == 'Покажи още..') {
        info.style.display = 'block';
        event.target.textContent = 'Скрий'
    }
    else {
        info.style.display = 'none';
        event.target.textContent = 'Покажи още..'
    }
}