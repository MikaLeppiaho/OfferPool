import { useState, useCallback, useEffect } from 'react';
import { OfferModel } from '../Models/offermodel';
import OfferService from '../Services/offerservice';
import OfferCard from '../Components/offercardcomponent';

export default function OfferListPage(): JSX.Element {
    const [list, setList] = useState<{} | undefined>(undefined);

    const getOffers = useCallback(() => {
        OfferService.getAllOffers().then((data) => {
            setList(
                data.map((a: OfferModel) => {
                    return (
                        <OfferCard
                            key={a.offer_id}
                            header={a.offer_header}
                            contact={a.offer_contact}
                        />
                    );
                })
            );
        });
    }, []);

    useEffect(() => {
        getOffers();
    }, [getOffers]);

    return <div>{list}</div>;
}
