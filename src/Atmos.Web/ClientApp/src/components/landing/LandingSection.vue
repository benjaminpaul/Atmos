<template>
    <section id="landing-section">
        <h2>{{landingTitle}}</h2>
        <p>{{landingText}}</p>
        <hr/>
        <div  style="visibility: hidden">
            <a href="#" class="btn btn-outline-light">Sign up for free</a> <a href="#" class="btn btn-link">Give it a little try first?</a>
        </div>
    </section>
</template>

<script>
    export default {
        name: "LandingSection",
        components: {
            
        },
        computed: {
            landingTitle() {
                return this.$store.state.landingConfig.landingTitle;
            },
            landingText() {
                return this.$store.state.landingConfig.landingText;
            }
        }
    }
</script>

<style scoped>
    #landing-section {
        margin-top: 100px;
        margin-bottom: 20px;
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