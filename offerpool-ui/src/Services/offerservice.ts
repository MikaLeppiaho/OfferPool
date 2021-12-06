import axios from 'axios';
import { OfferModel } from '../Models/offermodel';

let baseUrl: string = 'http://localhost:5000/api/offer/';

export const getAllOffers = async (): Promise<OfferModel[]> => {
    const response = await axios.get(baseUrl);
    return response.data;
};

export const createOffer = async (data: OfferModel): Promise<OfferModel> => {
    const request = await axios.post(baseUrl, data);
    return request.data;
};

const OfferService = {
    getAllOffers,
    createOffer,
};

export default OfferService;
