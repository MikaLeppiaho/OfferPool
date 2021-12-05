import axios from 'axios';
import { OfferModel } from '../Models/offermodel';

let baseUrl: string = 'http://localhost:5000/api/offer/';

export const getAllOffers = async (): Promise<OfferModel[]> => {
    const response = await axios.get(baseUrl);
    return response.data;
};

const OfferService = {
    getAllOffers,
};

export default OfferService;
