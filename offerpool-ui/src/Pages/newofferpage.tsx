import { SyntheticEvent, useState } from 'react';
import { OfferModel } from '../Models/offermodel';
import OfferService from '../Services/offerservice';

export default function NewOfferPage(): JSX.Element {
    const [offer, setOffer] = useState<OfferModel>({
        offer_contact: '',
        offer_header: '',
        offer_date_limit: '',
    });

    const handleInputChange = (event: SyntheticEvent) => {
        const { name, value } = event.target as any;

        setOffer({
            ...offer,
            [name]: value,
        });
    };

    const handleSubmit = (event: SyntheticEvent) => {
        event.preventDefault();
        console.log(offer);
        // OfferService.createOffer(offer as OfferModel);
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
                    <li>
                        <label htmlFor="offer_date_limit">
                            Määräaika tarjoukselle
                        </label>
                        <input
                            type="date"
                            id="offer_date_limit"
                            name="offer_date_limit"
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
