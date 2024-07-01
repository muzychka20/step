function checkPhone(phone) {
    if (phone.length && phone.length < 10 || phone.length > 12) {
        alert("Phone is incorrect")
        return false
    }  
    return true
}

function setCookie(name, value, days) {
    const d = new Date();
    d.setTime(d.getTime() + (days*24*60*60*1000));
    let expires = "expires="+ d.toUTCString();
    document.cookie = name + "=" + value + ";" + expires + ";path=/";
}

function getCookie(name) {
    const nameEQ = name + "=";
    const ca = document.cookie.split(';');
    for(let i=0; i < ca.length; i++) {
      let c = ca[i];
      while (c.charAt(0) == ' ') c = c.substring(1);
      if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function loginHandle(event) {

    event.preventDefault();

    let first_name = document.getElementById("first_name").value    
    let last_name = document.getElementById("last_name").value   
    let birthday = document.getElementById("birthday").value   
    let e = document.getElementById("gender")
    let gender = e.options[e.selectedIndex].text;      
    let phone = document.getElementById("phone").value    
    let skype = document.getElementById("skype").value
   
    if (!checkPhone(phone)) {
       return
    }

    user = {
        "first_name": first_name,
        "last_name": last_name,
        "birthday": birthday,
        "gender": gender,
        "phone": phone,
        "skype": skype,
    }

    let userString = JSON.stringify(user)
    setCookie('user', userString, 7)

    // localStorage.setItem('first_name', first_name)
    // localStorage.setItem('last_name', last_name)
    // localStorage.setItem('birthday', birthday)
    // localStorage.setItem('gender', gender)
    // localStorage.setItem('phone', phone)
    // localStorage.setItem('skype', skype)
    
    localStorage.setItem('user', userString)

    const userBlock = document.createElement('div')
    userBlock.className = 'user'
    userBlock.textContent = `${userString}`
    document.getElementById('users').appendChild(userBlock)    
}

window.onload = function() {
    let str = getCookie('user');    

    if (str) {
        let user = JSON.parse(str);
        console.log(user)
        alert('Welcome back, ' + user.first_name + '!')      
    } else {
      alert('Please log in.');
    }

    const first_name = localStorage.getItem('first_name')
    const last_name = localStorage.getItem('last_name')
    const birthday = localStorage.getItem('birthday')
    const gender = localStorage.getItem('gender')
    const phone = localStorage.getItem('phone')
    const skype = localStorage.getItem('skype')

    if (first_name && last_name && birthday && gender && phone && skype) {
        alert(`first_name: ${first_name}\nlast_name: ${last_name}\nbirthday: ${birthday}\ngender: ${gender}\nphone ${phone}\nskype: ${skype}`) // Показываем данные в alert
    } else {
        alert('No user data found in Local Storage.'); // Уведомление, если данные отсутствуют
    }
}