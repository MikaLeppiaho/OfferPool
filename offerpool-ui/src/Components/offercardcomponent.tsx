import { FC } from 'react';
import OfferButtonComponent from './Buttons/offerbuttoncomponent';

interface CardProps {
    header: string;
    contact: string;
    endDate: string;
}

const CardComponent: FC<CardProps> = ({ header, contact, endDate }) => {
    const dateDisplay = new Date(endDate);
    return (
        <div className="grid gap-4 bg-white rounded-xl shadow-md p-4">
            <h1>{header}</h1>
            <p>
                Eräpäivä:{' '}
                {dateDisplay.toLocaleString('fi-FI', {
                    dateStyle: 'medium',
                })}
            </p>
            <p>{contact}</p>
            <div className="place-self-end">
                <OfferButtonComponent />
            </div>
        </div>
    );
};

export default CardComponent;
