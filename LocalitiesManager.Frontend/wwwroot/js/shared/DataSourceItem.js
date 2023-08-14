import {SecurityHelper} from "../helpers/SecurityHelper.js";

export class DataSourceItem {
    uuid = null;

    constructor(properties) {
        if (!properties) throw new Error("properties can't be null");

        this.uuid = SecurityHelper.createUUID();
        this.#initializeProperties(properties);
    }

    #initializeProperties(properties) {
        for (const propertyKey in properties) {
            this[propertyKey] = properties[propertyKey]
        }
    }
}