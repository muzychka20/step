import Header from "./components/Header/Header";
import TeachingSection from "./components/TeachingSection/TeachingSection";
import DifferencesSection from "./components/DifferencesSection/DifferencesSection";
import IntroSection from "./components/IntroSection/IntroSection";
import TabsSection from "./components/TabsSection/TabsSection";
import FeedbackSection from "./components/FeedbackSection/FeedbackSection";
import { useState } from "react";
import EffectSection from "./components/EffectSection/EffectSection";

export default function App() {
  const [tab, setTab] = useState("effect");

  return (
    <>
      <Header />
      <main>
        <IntroSection />

        <TabsSection active={tab} onChange={(current) => setTab(current)} />

        {tab == "main" && (
          <>
            <TeachingSection />
            <DifferencesSection />
          </>
        )}

        {tab == "feedback" && <FeedbackSection />}

        {tab == "effect" && <EffectSection />}
      </main>
    </>
  );
}
