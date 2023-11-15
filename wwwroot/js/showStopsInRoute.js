let btns = document.querySelectorAll(".showStops")

for (let i = 0; i < btns.length; i++) {
    btns[i].addEventListener("click", ShowAndHideStops)
}

function ShowAndHideStops(event) {
    let parent = event.target.parentElement.parentElement;
    let info = parent.querySelector('.routeStops')
    if (event.target.textContent == 'See Stops') {
        info.style.display = 'block';
        event.target.textContent = 'Hide Stops'
    }
    else {
        info.style.display = 'none';
        event.target.textContent = 'See Stops'
    }
}