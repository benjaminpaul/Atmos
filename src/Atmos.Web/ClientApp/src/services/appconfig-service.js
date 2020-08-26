class AppconfigService {
    _config = null;
    get config() {
        return this._config;
    }
    async getConfig() {
        if (this._config !== null) {
            console.log("In memory config")
            return this._config;
        }
        
        console.log('Getting config');
        var config = await fetch("https://localhost:5001/appconfig");
        this._config = await config.json();
        return this._config;
    }
}

export let appConfigService = new AppconfigService();