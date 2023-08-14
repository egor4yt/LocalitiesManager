export class House {
    id = null;
    number = null;
    localityName = null;
    localityPrefix = null;
    streetName = null;
    streetPrefix = 0;
    apartmentsCount = 0;

    constructor(options) {
        this.id = options.id;
        this.number = options.number;
        this.localityName = options.localityName;
        this.localityPrefix = options.localityPrefix;
        this.streetName = options.streetName;
        this.streetPrefix = options.streetPrefix;
        this.apartmentsCount = options.apartmentsCount;
    }
}