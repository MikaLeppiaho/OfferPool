import { BrowserRouter, Link, Route, Routes } from 'react-router-dom';
import './App.css';
import HomePage from './Pages/homepage';
import OfferListPage from './Pages/offerlistpage';

function App() {
    return (
        <div>
            <nav>
                <Link className="link" to="/">
                    Home
                </Link>
                <Link className="link" to="/offerlist">
                    Offers
                </Link>
            </nav>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/offerlist" element={<OfferListPage />} />
            </Routes>
        </div>
    );
}

export default App;
