import {WebApiAdaptor} from "../../../shared/WebApiAdaptor.js";
import {House} from "../entities/House.js";

export function getHouses(skip, count, callback) {
    WebApiAdaptor.httpGetJsonAsync(`/api/houses/filter?skip=${skip}&count=${count}`)
        .then((response) => {
            if (!response?.payload?.items?.length) {
                console.warn("Houses not found", response);
                return [];
            }

            const houses = response.payload.items.map(x => new House(x));

            callback(houses);
        })
        .catch((error) => {
            console.error(error)
        });
}