import './Header.css';

function Header() {

    return (
        <header className="header">
            <div className="header-container">
                <img src="./logo512.png" alt="Logo" className="header-logo" />
                <span className="header-subtitle">Wizards</span>
            </div>
        </header>
    );
}
export default Header;