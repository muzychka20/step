import './Header.css'

export default function Header() {
    let date = new Date()
    return (
        <header>
            <div className="block">
                <img src="vite.svg" alt="" />
                <span>{date.toLocaleTimeString()}</span>
            </div>
            <div className="block">
                <h3>Demo project</h3>
                <span>{date.toLocaleTimeString()}</span>
            </div>
            <div className="block">
                <span>{ "time ".toUpperCase() }</span>
                <span>{date.toLocaleTimeString()}</span>
            </div>
        </header>
    )
}