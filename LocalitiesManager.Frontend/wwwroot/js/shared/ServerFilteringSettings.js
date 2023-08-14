import {WebApiAdaptor} from "./WebApiAdaptor.js";
import {ServerFilteringSchema} from "./ServerFilteringSchema.js";
import {ServerFilteringResponse} from "./ServerFilteringResponse.js";

export class ServerFilteringSettings {
    url = null;
    parameters = null;
    #schema = null;

    constructor(options) {
        if (!options) throw new Error("options can't be null");
        if (!options.url) throw new Error("options.url can't be null");

        this.url = options.url;
        this.parameters = options.parameters ?? {};
        this.#schema = new ServerFilteringSchema(options.schema);
    }

    filter(callback) {
        const queryString = `?` + Object.keys(this.parameters).map(x => `${encodeURI(x)}=${encodeURI(this.parameters[x])}`).join("&");

        WebApiAdaptor.httpGetJsonAsync(this.url + queryString)
            .then((response) => {
                const serverFilteringResponse = new ServerFilteringResponse(this.#schema, response.payload);
                callback(serverFilteringResponse);
            })
            .catch((error) => {
                console.error(error)
            });
    }
}