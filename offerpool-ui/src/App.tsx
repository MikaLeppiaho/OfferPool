import { Route, Routes } from 'react-router-dom';
import './App.css';
import NavigationLink from './Components/navigationlinkcomponent';
import HomePage from './Pages/homepage';
import NewOfferPage from './Pages/newofferpage';
import OfferListPage from './Pages/offerlistpage';

function App() {
    return (
        <div>
            <nav>
                <NavigationLink to="/" linkText="Koti" />
                <NavigationLink to="/offerlist" linkText="Tarjouslista" />
                <NavigationLink to="/createoffer" linkText="Uusi tarjous" />
            </nav>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/offerlist" element={<OfferListPage />} />
                <Route path="/createoffer" element={<NewOfferPage />} />
            </Routes>
        </div>
    );
}

export default App;
