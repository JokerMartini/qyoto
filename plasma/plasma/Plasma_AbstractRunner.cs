//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class AbstractRunner plasma/abstractrunner.h <Plasma/AbstractRunner>
    ///  Be aware that runners have to be thread-safe. This is due to
    ///  the fact that each runner is executed in its own thread for
    ///  each new term. Thus, a runner may be executed more than once
    ///  at the same time.
    ///  </remarks>        <short> An abstract base class for Plasma Runner plugins. </short>
    [SmokeClass("Plasma::AbstractRunner")]
    public abstract class AbstractRunner : QObject {
        protected AbstractRunner(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(AbstractRunner), this);
        }
        /// <remarks> Specifies a nominal speed for the runner </remarks>        <short>   Specifies a nominal speed for the runner </short>
        public enum Speed {
            SlowSpeed = 0,
            NormalSpeed = 1,
        }
        /// <remarks> Specifies a priority for the runner </remarks>        <short>   Specifies a priority for the runner </short>
        public enum Priority {
            LowestPriority = 0,
            LowPriority = 1,
            NormalPriority = 2,
            HighPriority = 3,
            HighestPriority = 4,
        }
        // QMutex* bigLock(); >>>> NOT CONVERTED
        /// <remarks>
        ///  This is the main query method. It should trigger creation of
        ///  QueryMatch instances through RunnerContext.AddInformationalMatch,
        ///  RunnerContext.AddExactMatch, and RunnerContext.AddPossibleMatch.
        ///  If the runner can run precisely the requested term (RunnerContext.Query()),
        ///  it should create an exact match (RunnerContext.AddExactMatch).
        ///  The first runner that creates a QueryMatch will be the
        ///  default runner. Other runner's matches will be suggested in the
        ///  interface. Non-exact matches should be offered via RunnerContext.AddPossibleMatch.
        ///  The match will be activated if the user selects it.
        ///  If this runner's exact match is selected, it will be passed into
        ///  the run method.
        ///  Since each runner is executed in its own thread there is no need
        ///  to return from this method right away, nor to create all matches
        ///  here.
        ///          </remarks>        <short>    This is the main query method.</short>
        ///         <see> run</see>
        [SmokeMethod("match(Plasma::RunnerContext&)")]
        public virtual void Match(Plasma.RunnerContext context) {
            interceptor.Invoke("match#", "match(Plasma::RunnerContext&)", typeof(void), typeof(Plasma.RunnerContext), context);
        }
        /// <remarks>
        ///  Triggers a call to match.
        ///  @arg globalContext the search context used in executing this match.
        ///          </remarks>        <short>    Triggers a call to match.</short>
        public void PerformMatch(Plasma.RunnerContext context) {
            interceptor.Invoke("performMatch#", "performMatch(Plasma::RunnerContext&)", typeof(void), typeof(Plasma.RunnerContext), context);
        }
        /// <remarks>
        ///  If the runner has options that the user can interact with to modify
        ///  what happens when run or one of the actions created in fillMatches
        ///  is called, the runner should return true
        ///          </remarks>        <short>    If the runner has options that the user can interact with to modify  what happens when run or one of the actions created in fillMatches  is called, the runner should return true          </short>
        public bool HasRunOptions() {
            return (bool) interceptor.Invoke("hasRunOptions", "hasRunOptions()", typeof(bool));
        }
        /// <remarks>
        ///  If hasRunOptions() returns true, this method may be called to get
        ///  a widget displaying the options the user can interact with to modify
        ///  the behaviour of what happens when a given match is selected.
        /// <param> name="widget" the parent of the options widgets.
        ///          </param></remarks>        <short>    If hasRunOptions() returns true, this method may be called to get  a widget displaying the options the user can interact with to modify  the behaviour of what happens when a given match is selected.</short>
        [SmokeMethod("createRunOptions(QWidget*)")]
        public virtual void CreateRunOptions(QWidget widget) {
            interceptor.Invoke("createRunOptions#", "createRunOptions(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks>
        ///  Called whenever an exact or possible match associated with this
        ///  runner is triggered.
        ///          </remarks>        <short>    Called whenever an exact or possible match associated with this  runner is triggered.</short>
        [SmokeMethod("run(const Plasma::RunnerContext&, const Plasma::QueryMatch&)")]
        public virtual void Run(Plasma.RunnerContext context, Plasma.QueryMatch action) {
            interceptor.Invoke("run##", "run(const Plasma::RunnerContext&, const Plasma::QueryMatch&)", typeof(void), typeof(Plasma.RunnerContext), context, typeof(Plasma.QueryMatch), action);
        }
        /// <remarks>
        ///  The nominal speed of the runner.
        /// </remarks>        <short>    The nominal speed of the runner.</short>
        ///         <see> setSpeed</see>
        public Plasma.AbstractRunner.Speed speed() {
            return (Plasma.AbstractRunner.Speed) interceptor.Invoke("speed", "speed() const", typeof(Plasma.AbstractRunner.Speed));
        }
        /// <remarks>
        ///  The priority of the runner.
        /// </remarks>        <short>    The priority of the runner.</short>
        ///         <see> setPriority</see>
        public Plasma.AbstractRunner.Priority priority() {
            return (Plasma.AbstractRunner.Priority) interceptor.Invoke("priority", "priority() const", typeof(Plasma.AbstractRunner.Priority));
        }
        /// <remarks>
        ///  Returns the OR'ed value of all the Information types (as defined in RunnerContext.Type)
        ///  this runner is not interested in.
        /// </remarks>        <return> OR'ed value of black listed types
        ///          </return>
        ///         <short>    Returns the OR'ed value of all the Information types (as defined in RunnerContext.Type)  this runner is not interested in.</short>
        public uint IgnoredTypes() {
            return (uint) interceptor.Invoke("ignoredTypes", "ignoredTypes() const", typeof(uint));
        }
        /// <remarks>
        ///  Sets the types this runner will ignore
        /// <param> name="types" OR'ed listed of ignored types
        ///          </param></remarks>        <short>    Sets the types this runner will ignore </short>
        public void SetIgnoredTypes(uint types) {
            interceptor.Invoke("setIgnoredTypes$", "setIgnoredTypes(Plasma::RunnerContext::Types)", typeof(void), typeof(uint), types);
        }
        /// <remarks>
        ///  Returns the user visible engine name for the Runner
        ///           </remarks>        <short>    Returns the user visible engine name for the Runner           </short>
        public string Name() {
            return (string) interceptor.Invoke("name", "name() const", typeof(string));
        }
        /// <remarks>
        ///  Returns an id string for the Runner
        ///           </remarks>        <short>    Returns an id string for the Runner           </short>
        public string Id() {
            return (string) interceptor.Invoke("id", "id() const", typeof(string));
        }
        /// <remarks>
        ///  Returns the description of this Runner
        ///           </remarks>        <short>    Returns the description of this Runner           </short>
        public string Description() {
            return (string) interceptor.Invoke("description", "description() const", typeof(string));
        }
        /// <remarks>
        ///  Accessor for the associated Package object if any.
        ///  Note that the returned pointer is only valid for the lifetime of
        ///  the runner.
        /// </remarks>        <return> the Package object, or 0 if none
        /// </return>
        ///         <short>    Accessor for the associated Package object if any.</short>
        public Plasma.Package Package() {
            return (Plasma.Package) interceptor.Invoke("package", "package() const", typeof(Plasma.Package));
        }
        /// <remarks>
        ///  Signal runner to reload its configuration.
        ///          </remarks>        <short>    Signal runner to reload its configuration.</short>
        [SmokeMethod("reloadConfiguration()")]
        public virtual void ReloadConfiguration() {
            interceptor.Invoke("reloadConfiguration", "reloadConfiguration()", typeof(void));
        }
        /// <remarks>
        ///  Constructs a Runner object. Since AbstractRunner has pure virtuals,
        ///  this constructor can not be called directly. Rather a subclass must
        ///  be created
        ///          </remarks>        <short>    Constructs a Runner object.</short>
        public AbstractRunner(QObject parent, string serviceId) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractRunner#$", "AbstractRunner(QObject*, const QString&)", typeof(void), typeof(QObject), parent, typeof(string), serviceId);
        }
        public AbstractRunner(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractRunner#", "AbstractRunner(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public AbstractRunner() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractRunner", "AbstractRunner()", typeof(void));
        }
        public AbstractRunner(QObject parent, List<QVariant> args) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractRunner#?", "AbstractRunner(QObject*, const QList<QVariant>&)", typeof(void), typeof(QObject), parent, typeof(List<QVariant>), args);
        }
        /// <remarks>
        ///  Provides access to the runner's configuration object.
        ///          </remarks>        <short>    Provides access to the runner's configuration object.</short>
        protected KConfigGroup Config() {
            return (KConfigGroup) interceptor.Invoke("config", "config() const", typeof(KConfigGroup));
        }
        /// <remarks>
        ///  Sets whether or not the runner has options for matches
        ///          </remarks>        <short>    Sets whether or not the runner has options for matches          </short>
        protected void SetHasRunOptions(bool hasRunOptions) {
            interceptor.Invoke("setHasRunOptions$", "setHasRunOptions(bool)", typeof(void), typeof(bool), hasRunOptions);
        }
        /// <remarks>
        ///  Sets the nominal speed of the runner. Only slow runners need
        ///  to call this within their constructor because the default
        ///  speed is NormalSpeed. Runners that use DBUS should call
        ///  this within their constructors.
        ///          </remarks>        <short>    Sets the nominal speed of the runner.</short>
        protected void SetSpeed(Plasma.AbstractRunner.Speed newSpeed) {
            interceptor.Invoke("setSpeed$", "setSpeed(Plasma::AbstractRunner::Speed)", typeof(void), typeof(Plasma.AbstractRunner.Speed), newSpeed);
        }
        /// <remarks>
        ///  Sets the priority of the runner. Lower priority runners are executed
        ///  only after higher priority runners.
        ///          </remarks>        <short>    Sets the priority of the runner.</short>
        protected void SetPriority(Plasma.AbstractRunner.Priority newPriority) {
            interceptor.Invoke("setPriority$", "setPriority(Plasma::AbstractRunner::Priority)", typeof(void), typeof(Plasma.AbstractRunner.Priority), newPriority);
        }
        /// <remarks>
        ///  A blocking method to do queries of installed Services which can provide
        ///  a measure of safety for runners running their own threads. This should
        ///  be used instead of calling KServiceTypeTrader.Query(..) directly.
        ///  @arg serviceType a service type like "Plasma/Applet" or "KFilePlugin"
        ///  @arg constraint a constraint to limit the choices returned.
        /// </remarks>        <return> a list of services that satisfy the query.
        ///          </return>
        ///         <short>    A blocking method to do queries of installed Services which can provide  a measure of safety for runners running their own threads.</short>
        ///         <see> KServiceTypeTrader.Query(const</see>
        ///         <see> const</see>
        protected List<KService> ServiceQuery(string serviceType, string constraint) {
            return (List<KService>) interceptor.Invoke("serviceQuery$$", "serviceQuery(const QString&, const QString&) const", typeof(List<KService>), typeof(string), serviceType, typeof(string), constraint);
        }
        protected List<KService> ServiceQuery(string serviceType) {
            return (List<KService>) interceptor.Invoke("serviceQuery$", "serviceQuery(const QString&) const", typeof(List<KService>), typeof(string), serviceType);
        }
        [Q_SLOT("void init()")]
        protected void Init() {
            interceptor.Invoke("init", "init()", typeof(void));
        }
        protected new IAbstractRunnerSignals Emit {
            get { return (IAbstractRunnerSignals) Q_EMIT; }
        }
    }

    public interface IAbstractRunnerSignals : IQObjectSignals {
    }
}
