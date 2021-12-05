import React, { FC } from 'react';
import './offercardcomponent.css';

interface CardProps {
    header: string;
    contact: string;
}

const CardComponent: FC<CardProps> = ({ header, contact }) => {
    return (
        <div className="CardComponent">
            <h1>{header}</h1>
            <p>{contact}</p>
        </div>
    );
};

export default CardComponent;
