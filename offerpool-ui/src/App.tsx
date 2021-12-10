import { Route, Routes } from 'react-router-dom';
import NavigationLink from './Components/navigationlinkcomponent';
import HomePage from './Pages/homepage';
import NewOfferPage from './Pages/newofferpage';
import OfferListPage from './Pages/offerlistpage';

function App() {
    return (
        <div>
            <nav className="shadow p-4 mb-5">
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
