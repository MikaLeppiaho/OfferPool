import { FC } from 'react';

const OfferButtonComponent: FC = () => {
    return (
        <div>
            <button
                className="
                    p-1 
                    bg-green-500 
                    shadow 
                    shadow-green-500/50 
                    rounded
                    hover:bg-green-100
                    hover:shadow-green-100/50
                    place-self-end
                    "
            >
                Avaa
            </button>
        </div>
    );
};

export default OfferButtonComponent;
