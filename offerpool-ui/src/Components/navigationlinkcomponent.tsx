import { FC } from 'react';
import { Link } from 'react-router-dom';

interface propType {
    to: string;
    linkText: string;
}

const NavigationLink: FC<propType> = ({ to, linkText }) => {
    return (
        <Link className="link" to={to}>
            {linkText}
        </Link>
    );
};

export default NavigationLink;
