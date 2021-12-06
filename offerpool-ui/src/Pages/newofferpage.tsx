import { SyntheticEvent, useState } from 'react';
import { OfferModel } from '../Models/offermodel';
import OfferService from '../Services/offerservice';

export default function NewOfferPage(): JSX.Element {
    const [offer, setOffer] = useState({});

    const handleInputChange = (event: SyntheticEvent) => {
        const { name, value } = event.target as any;

        setOffer({
            ...offer,
            [name]: value,
        });
    };

    const handleSubmit = (event: SyntheticEvent) => {
        event.preventDefault();
        OfferService.createOffer(offer as OfferModel);
    };

    return (
        <div className="contentCard">
            <h1>Uusi tarjouspyyntö</h1>
            <form onSubmit={handleSubmit}>
                <ul>
                    <li>
                        <label htmlFor="offer_header">Kuvaus</label>
                        <input
                            type="text"
                            id="offer_header"
                            name="offer_header"
                            onChange={handleInputChange}
                        />
                    </li>
                    <li>
                        <label htmlFor="offer_contact">Yhteystiedot</label>
                        <input
                            type="text"
                            id="offer_contact"
                            name="offer_contact"
                            onChange={handleInputChange}
                        />
                    </li>
                    <li className="button">
                        <button type="submit">Send new offer</button>
                    </li>
                </ul>
            </form>
        </div>
    );
}
