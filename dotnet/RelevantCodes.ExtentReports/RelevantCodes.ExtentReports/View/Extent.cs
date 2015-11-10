﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevantCodes.ExtentReports.View
{
    internal class Extent
    {
        public static string Source
        {
            get
            {
                return @"
                    <!DOCTYPE html>
                    <html>
                        <head>
                            <!--
                                ExtentReports Library 2.40.0 | http://relevantcodes.com/extentreports-for-selenium/ | https://github.com/anshooarora/
                                Copyright (c) 2015, Anshoo Arora (Relevant Codes) | Copyrights licensed under the New BSD License | http://opensource.org/licenses/BSD-3-Clause
                                Documentation: http://extentreports.relevantcodes.com 
                            -->
                            <meta http-equiv='content-type' content='text/html; charset=utf-8' /> 
                            <meta name='description' content='ExtentReports (by Anshoo Arora) is a reporting library for automation testing for .NET and Java. It creates detailed and beautiful HTML reports for modern browsers. ExtentReports shows test and step summary along with dashboards, system and environment details for quick analysis of your tests.' />
                            <meta name='robots' content='noodp, noydir' />
                            <meta name='viewport' content='width=device-width, initial-scale=1' />
                            <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css' type='text/css'>
                            <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.1/css/materialize.min.css' type='text/css'>
                            <link href='https://cdn.rawgit.com/noelboss/featherlight/1.3.4/release/featherlight.min.css' type='text/css' rel='stylesheet' />
                            <link href='http://cdn.rawgit.com/anshooarora/extentreports/master/dist-artifacts/extent.css' type='text/css' rel='stylesheet' />
                            <title>ExtentReports 2.40</title>
                        </head>
                        <body class='extent'>  
                            <nav>
                                <ul id='slide-out' class='side-nav fixed'>
                                    <li class='logo'>
                                        <a class='left hide' href='http://extentreports.relevantcodes.com'><span>ExtentReports</span></a>
                                        <a class='menu-toggle right'><i class='fa fa-bars fa-2x'></i></a>
                                    </li> 
                                    <li class='analysis waves-effect active'><a href='#!' class='test-view'><i class='mdi-action-dashboard'></i>Test Details</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='categories-view'><i class='mdi-maps-local-offer'></i>Categories</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='dashboard-view'><i class='fa fa-line-chart'></i></i>Analysis</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='testrunner-logs-view'><i class='mdi-action-assignment'></i>TestRunner Logs</a></li>
                                </ul>
                                <a href='#' data-activates='slide-out' class='button-collapse'><i class='fa fa-bars fa-2x'></i></a>
                                <span class='report-name'>Automation Report</span> <span class='report-headline'></span>
                                <ul class='right hide-on-med-and-down nav-right'>
                                    <li class='test-view-only'>
                                        <input type='checkbox' id='enableDashboard' />
                                        <label for='enableDashboard'>Enable Dashboard</label>
                                    </li>
                                    <li>
                                        <input type='checkbox' class='enabled' id='refreshCharts' />
                                        <label for='refreshCharts'>Redraw Charts on Filter</label>
                                    </li>
                                    <li>
                                        <span class='suite-started-time'></span>
                                    </li>
                                    <li>
                                        <span>v2.40.0</span>
                                    </li>
                                </ul>
                            </nav>
                            <div class='container'>
                                <div id='dashboard-view' class='row'>
                                    <div class='time-totals'>
                                        <div class='col l2 m4 s6'>
                                            <div class='card suite-total-tests'> 
                                                <span class='panel-name'>Total Tests</span> 
                                                <span class='total-tests'> <span class='panel-lead'></span> </span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m4 s6'>
                                            <div class='card suite-total-steps'> 
                                                <span class='panel-name'>Total Steps</span> 
                                                <span class='total-steps'> <span class='panel-lead'></span> </span> 
                                            </div> 
                                        </div>
                                        <div class='col l4 m4 s12'>
                                            <div class='card suite-total-steps'> 
                                                <span class='panel-name'>Total Time Taken</span> 
                                                <span class='suite-total-time-taken panel-lead'></span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m6 s6 suite-start-time'>
                                            <div class='card green-accent'> 
                                                <span class='panel-name'>Start</span> 
                                                <span class='panel-lead suite-started-time'></span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m6 s6 suite-end-time'>
                                            <div class='card pink-accent'> 
                                                <span class='panel-name'>End</span> 
                                                <span class='panel-lead suite-ended-time'></span> 
                                            </div> 
                                        </div>
                                    </div>
                                    <div class='charts'>
                                        <div class='col s12 m6 l4 fh'> 
                                            <div class='card-panel'> 
                                                <div>
                                                    <span class='panel-name'>Tests View</span>
                                                </div> 
                                                <div class='panel-setting modal-trigger test-count-setting right'>
                                                    <a href='#test-count-setting'><i class='mdi-navigation-more-vert text-md'></i></a>
                                                </div> 
                                                <div class='chart-box'>
                                                    <canvas class='text-centered' id='test-analysis'></canvas>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='t-pass-count weight-normal'></span> test(s) passed</span>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='t-fail-count weight-normal'></span> test(s) failed, <span class='t-others-count weight-normal'></span> others</span>
                                                </div> 
                                            </div> 
                                        </div> 
                                        <div class='col s12 m6 l4 fh'> 
                                            <div class='card-panel'> 
                                                <div>
                                                    <span class='panel-name'>Steps View</span>
                                                </div> 
                                                <div class='panel-setting modal-trigger step-status-filter right'>
                                                    <a href='#step-status-filter'><i class='mdi-navigation-more-vert text-md'></i></a>
                                                </div> 
                                                <div class='chart-box'>
                                                    <canvas class='text-centered' id='step-analysis'></canvas>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='s-pass-count weight-normal'></span> step(s) passed</span>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='s-fail-count weight-normal'></span> step(s) failed, <span class='s-others-count weight-normal'></span> others</span>
                                                </div> 
                                            </div> 
                                        </div>
                                        <div class='col s12 m12 l4 fh'> 
                                            <div class='card-panel'> 
                                                <span class='panel-name'>Pass Percentage</span> 
                                                <span class='pass-percentage panel-lead'></span> 
                                                <div class='progress light-blue lighten-3'> 
                                                    <div class='determinate light-blue'></div> 
                                                </div> 
                                            </div> 
                                        </div>
                                    </div>
                                    <div class='system-view'>
                                        <div class='col l4 m12 s12'>
                                            <div class='card-panel'>
                                                <span class='label info right'>Environment</span>
                                                <table>
                                                    <thead>
                                                        <tr>
                                                            <th>Param</th>
                                                            <th>Value</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <!--SystemInfo-->
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='category-summary-view'>
                                        <div class='col l2 m6 s12 hide'>
                                            <div class='card-panel'>
                                                <span class='label info right'>Categories</span>
                                                <table>
                                                    <thead>
                                                        <tr>
                                                            <th>Name</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='test-view' class='row'>
                                    <div class='col s5'>
                                        <div class='card-panel filters'>
                                            <div class='input-field no-margin-v'>
                                                <input id='searchTests' type='text' class='validate'>
                                                <span class='clear'><i class='mdi-navigation-close'></i></span>
                                                <label class='active' for='searchTests'>Search Tests..</label>
                                            </div>
                                            <div class='row'>
                                                <div class='col s6'>
                                                    <div class='input-field tests-toggle'>
                                                        <select>
                                                            <option value='0' selected>Choose your option</option>
                                                            <option value='1'>Pass</option>
                                                            <option value='2'>Fatal</option>
                                                            <option value='3'>Fail</option>
                                                            <option value='4'>Error</option>
                                                            <option value='5'>Warning</option>
                                                            <option value='6'>Skip</option>
                                                            <option value='7'>Unknown</option>
                                                            <option value='8'>Clear Filters</option>
                                                        </select>
                                                        <label>Filter By Status</label>
                                                    </div>
                                                </div>
                                                <div class='col s6'>
                                                    <div class='input-field category-toggle'>
                                                        <select>
                                                            <option value='0' selected>Choose your option</option>
                                                            <option value='8'>Clear Filters</option>
                                                        </select>
                                                        <label>Filter By Category</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class='card-panel no-padding-h no-padding-v'>
                                            <div class='wrapper'>
                                                <ul id='test-collection' class='test-collection'>
                                                    <!--%Test%-->
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div id='test-details-wrapper' class='col s7'>
                                        <div class='card-panel vh100 details-view pin'>
                                            <h5 class='details-name'></h5>
                                            <div class='details-container'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='categories-view' class='row hide'>
                                    <div class='col s5'>
                                        <div class='card-panel filters'>
                                            <div class='input-field no-margin-v'>
                                                <input id='searchCats' type='text' class='validate'>
                                                <span class='clear'><i class='mdi-navigation-close'></i></span>
                                                <label class='active' for='searchCats'>Search Categories..</label>
                                            </div>
                                        </div>
                                        <div class='card-panel no-padding-h no-padding-v vh100'>
                                            <div class='wrapper'>
                                                <ul id='cat-collection' class='cat-collection'>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div id='cat-details-wrapper' class='col s7'>
                                        <div class='card-panel vh100 details-view pin'>
                                            <h5 class='cat-name'></h5>
                                            <div class='cat-container'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='testrunner-logs-view' class='row hide'>
                                    <div class='col s12'>
                                        <div class='card-panel'>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div id='test-count-setting' class='modal bottom-sheet'> 
                                <div class='modal-content'> 
                                    <h5>Configure Tests Count Setting</h5> 
                                    <input name='test-count-setting' type='radio' id='parentWithoutNodes' class='with-gap'> 
                                    <label for='parentWithoutNodes'>Parent Tests Only (Does not include child nodes in counts)</label> 
                                    <br> 
                                    <input name='test-count-setting' type='radio' id='parentWithoutNodesAndNodes' class='with-gap'> 
                                    <label for='parentWithoutNodesAndNodes'>Parent Tests Without Child Tests + Child Tests</label> 
                                    <br> 
                                    <input name='test-count-setting' type='radio' id='childNodes' class='with-gap'> 
                                    <label for='childNodes'>Child Tests Only</label> 
                                </div> 
                                <div class='modal-footer'> 
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn'>Save</a> 
                                </div> 
                            </div> 
                            <div id='step-status-filter' class='modal bottom-sheet'> 
                                <div class='modal-content'> 
                                    <h5>Select status</h5> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-pass'> 
                                    <label for='step-dashboard-filter-pass'>Pass</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-fail'> 
                                    <label for='step-dashboard-filter-fail'>Fail</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-fatal'> 
                                    <label for='step-dashboard-filter-fatal'>Fatal</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-error'> 
                                    <label for='step-dashboard-filter-error'>Error</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-warning'> 
                                    <label for='step-dashboard-filter-warning'>Warning</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-skip'> 
                                    <label for='step-dashboard-filter-skip'>Skipped</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-info'> 
                                    <label for='step-dashboard-filter-info'>Info</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-unknown'> 
                                    <label for='step-dashboard-filter-unknown'>Unknown</label> 
                                </div> 
                                <div class='modal-footer'> 
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn'>Save</a> 
                                </div> 
                            </div>
                            <script src='https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js'></script> 
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.1/js/materialize.min.js'></script>
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/Chart.js/1.0.2/Chart.min.js'></script>
                            <script src='https://cdn.rawgit.com/noelboss/featherlight/1.3.4/release/featherlight.min.js' type='text/javascript' charset='utf-8'></script>
                            <script src='http://cdn.rawgit.com/anshooarora/extentreports/master/dist-artifacts/extent.js' type='text/javascript'></script>
                        </body>
                    </html>".Replace("    ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
            }
        }
    }
}