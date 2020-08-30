import Vue from "vue";
import Vuex from "vuex";
import { mixStorageService } from "./services/MixStorageService";

Vue.use(Vuex);

export const store = new Vuex.Store({
    state: {
        appTitle: "HELLO WORLD",
        landingConfig: {},
        soundClips: [],
        appConfig: {},
        mixes: [],
        activeMix: null,
        showMixPanel: false
    },
    mutations: {
        SAVE_APPCONFIG(state, config) {
            state.appConfig = config;
            state.landingConfig = config.landingConfig;
        },
        SAVE_SOUNDCLIPS(state, clips) {
            state.soundClips = clips.map(x => {
                return {
                    id: x.id,
                    title: x.title,
                    description: x.description,
                    audioSources: [x.fileName],
                    icon: require(`./assets/${x.iconFileName}`)
                }
            });
        },
        SAVE_MIXES(state, mixes) {
            state.mixes = mixes;
        },
        SELECT_ACTIVE_MIX(state, mix) {
            state.activeMix = mix;
        },
        SHOW_MIX_PANEL(state, show) {
            state.showMixPanel = show;
        }
    },
    actions: {
        loadConfig({commit}) {
            Vue.axios.get("appconfig").then(result => {
                commit('SAVE_APPCONFIG', result.data);
            }).catch(error => {
                throw new Error(`Failed fetching config: ${error}`)
            })
        },
        loadSoundClips({commit}) {
            Vue.axios.get("soundclips").then(result => {
                commit('SAVE_SOUNDCLIPS', result.data);
            }).catch(error => {
                throw new Error(`Failed fetching sound clips: ${error}`);
            })
        },
        loadMixes({commit}) {
            let storedMixes = mixStorageService.getStoredMixes();
            commit('SAVE_MIXES', storedMixes);
        },
        activateMix({commit}, mix) {
            commit('SELECT_ACTIVE_MIX', mix);
        },
        showMixPanel({commit}, value) {
            console.log('show')
            console.log(value)
            commit('SHOW_MIX_PANEL', value);
        }
    }
})