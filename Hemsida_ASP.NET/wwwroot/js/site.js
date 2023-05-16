try {
    const toggleBtn = document.querySelector('[data-option="toggle"]')
    toggleBtn.addEventListener('click', function () {
        const element = document.querySelector(toggleBtn.getAttribute('data-target'))

        if (!element.classList.contains('open-menu')) {
            element.classList.add('open-menu')
            toggleBtn.classList.add('btn-outline-dark')
            toggleBtn.classList.add('btn-toggle-white')
        }

        else {
            element.classList.remove('open-menu')
            toggleBtn.classList.remove('btn-outline-dark')
            toggleBtn.classList.remove('btn-toggle-white')
        }
    })
} catch { }


let elements = document.querySelectorAll('[data-val="true"]');

for (let element of elements) {
    element.addEventListener("keyup", function (e) {
        switch (e.target.type) {
            case 'text':
                textValidator(e.target, 2);
                break;
            case 'password':
                passwordValidator(e.target);
                break;
        }
    })
}

function textValidator(target, minLength) {

    //const regEx = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    // || !regEx.test(target.value

    if (target.value.length < minLength)
            document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`;
        else
            document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = "";     
        }

function passwordValidator(target) {

    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s])[^\s]{8,}$/;

    if (!regEx.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`;
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = "";
    }
         
            