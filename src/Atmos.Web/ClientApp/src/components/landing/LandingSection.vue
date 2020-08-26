<template>
    <section id="landing-section">
        <h2>{{title}}</h2>
        <p>{{text}}</p>
        <hr/>
        <div  style="visibility: hidden">
            <a href="#" class="btn btn-outline-light">Sign up for free</a> <a href="#" class="btn btn-link">Give it a little try first?</a>
        </div>
    </section>
</template>

<script>
    import { appConfigService} from "../../services/appconfig-service";

    export default {
        name: "LandingSection",
        components: {
            
        },
        data() {
            return {
                title: "",
                text: ""
            }
        },
        async created() {
            await this.populateData();
        },
        methods: {
            async populateData() {
                var t = await appConfigService.getConfig();
                this.title = t.landingConfig.landingTitle;
                this.text = t.landingConfig.landingText;
            }
        }
    }
</script>

<style scoped>
    #landing-section {
        margin-top: 100px;
        margin-bottom: 100px;
    }
    p {
        margin-top: 30px;
        margin-bottom: 30px;
    }
    a {
        margin-top: 30px;
        color: #fff;
    }
</style>