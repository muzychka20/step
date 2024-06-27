const cookie = {
    setCookie: (name, value, hours) => {
        const d = new Date()
        d.setTime(d.getTime() + + (hours * 60 * 60 * 1000))
        let expires = 'expires=' + d.toUTCString()
        document.cookie = name + '=' + value + ';' + expires + ';path=/'
    },

    getCookie: (name) => {
        const nameEQ = name + "="
        const ca = document.cookie.split(';')
        for(let i=0; i < ca.length; i++) {
            let c = ca[i]
            while (c.charAt(0) == ' ') c = c.substring(1)
            if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length)
        }
        return null
    },
}

export const setCookie = cookie.setCookie
export const getCookie = cookie.getCookie